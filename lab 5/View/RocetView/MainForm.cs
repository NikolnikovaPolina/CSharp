using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using RocetModel;   
namespace RocetView
{
    public partial class MainForm : Form
    {
        // список объектов
        List<ViewObject> viewObjects;
        object viewObjectsLocker;

        List<ViewModel> viewModels;
        object viewModelsLocker;

        // рисователь всех объектов
        Painter painter;

        //здания на карте

        ViewObject insurance, gym;

        // космонавты
        List<Astronaut> astronaut;
        object astronautsLocker;

        // соревнования
        List<Launch> launch;

        // запуски будут только в в левой части экрана находиться

        int maxCompetitionsNumber;

        IEnumerable<Type> paymantTypes;

        // будем хранить все уведомления, чтобы их постепенно очищать
        List<string> notifications;

        // картинки моделей
        // лучше сделать ссылки на них, так проще будет изменять код при изменении картинок
        Image astronautImage,
            moneyImage,
            homeImage,
            rocetImage,
            insuranceImage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem StartToolStripMenuItem;
        private ToolStripMenuItem AddAstronautToolStripMenuItem;
        private ToolStripMenuItem AddRocetToolStripMenuItem;
        private TextBox notificationTextBox;
        private ToolStripMenuItem AddMoneyToolStripMenuItem;
        private PictureBox pictureBox;

        public MainForm()
        {
            InitializeComponent();

            InitImages();

            viewObjects = new List<ViewObject>();
            viewObjectsLocker = new object();

            viewModels = new List<ViewModel>();
            viewModelsLocker = new object();

            astronaut = new List<Astronaut>();
            astronautsLocker = new object();

            paymantTypes = Assembly.Load("RocetModel").GetTypes().Where(type => !type.IsAbstract && type.GetInterface("IInserance") != null);


            notifications = new List<string>();

            maxCompetitionsNumber = (int)(pictureBox.Height / rocetImage.Height);

            launch = new List<Launch>();
        }

        void InitImages()
        {
            astronautImage = Properties.Resources.Astronaut;
            moneyImage = Properties.Resources.Money;
            homeImage = Properties.Resources.Home;
            rocetImage = Properties.Resources.Rocet;
            insuranceImage = Properties.Resources.Insurance;
        }

        void Notification(string message)
        {
            notificationTextBox.Invoke((MethodInvoker)delegate
            {
                notifications.Add(message);

                if (notifications.Count >= 15)
                {
                    // clear
                    notifications = notifications.GetRange(5, 9);

                    notificationTextBox.Text = "";

                    foreach (var item in notifications)
                    {
                        notificationTextBox.Text += item + "\r\n\r\n";
                    }
                }

                notificationTextBox.Text += message + "\r\n\r\n";
            });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // закрываем все задачи

            painter.Stop();

            foreach (var item in launch)
            {
                item.IsCanceled = true;
            }

            foreach (var item in viewModels)
            {
                if (item is ViewModel viewModel)
                    viewModel.Model.IsCanceled = true;
            }
        }

        void InputPersonModel(PersonModel personModel)
        {
            // input firstName, lastName

            InputStringDialog inputLastName = new InputStringDialog(new WordValidator(), "Введите Фамилию");

            if (inputLastName.ShowDialog() == DialogResult.OK)
            {
                personModel.LastName = inputLastName.Value;
            }

            InputStringDialog inputFirstName = new InputStringDialog(new WordValidator(), "Введите Имя");

            if (inputFirstName.ShowDialog() == DialogResult.OK)
            {
                personModel.FirstName = inputFirstName.Value;
            }
        }

        private void AddAstronautToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Astronaut newAstronaut = new Astronaut(Notification, gym.X, gym.Y);

            InputPersonModel(newAstronaut);

            // add to list and add to view

            lock (astronautsLocker)
            {
                astronaut.Add(newAstronaut);
            }

            lock (viewModels)
            {
                viewModels.Add(new ViewModel(newAstronaut, astronautImage));
            }

            // запустим космонавта
            Task.Run(newAstronaut.Start);
        }

        void SetBuildingsSize()
        {
            // задаём центры зданий в завимости от размеров pictureBox и картинок

            // больница будет в левом верхнем углу
            insurance.X = pictureBox.Width - insuranceImage.Width / 2;
            insurance.Y = insuranceImage.Height / 2;

            // тренажёрный зал будет в правом нижнем углу

            gym.X = pictureBox.Width - homeImage.Width / 2;
            gym.Y = pictureBox.Height - homeImage.Height / 2;
        }

        void AddRocet(string launchName, int maxParticipatingAstronautsNumber = 3)
        {
            float x = rocetImage.Width / 2,
                y = rocetImage.Height / 2;

            y += launch.Count() * rocetImage.Height;

            launch.Add(new Launch(Notification, astronaut, astronautsLocker, x, y, launchName, maxParticipatingAstronautsNumber));

            lock (viewObjectsLocker)
            {
                viewObjects.Add(new ViewObject(rocetImage, x, y));
            }

            Task.Run(launch[launch.Count() - 1].Start);

            if (launch.Count() >= maxCompetitionsNumber)
                AddRocetToolStripMenuItem.Enabled = false;
        }

        void GenerateAstronauts(int sportmansNumber)
        {
            // создадим несколько космонавтов, выплат, запусков, запустим их в потоках

            for (int i = 0; i < sportmansNumber; i++)
            {
                var newAstronaut = new Astronaut(Notification, gym.X, gym.Y)
                {
                    LastName = "SpLast" + i.ToString(),
                    FirstName = "SpFirst" + i.ToString()
                };

                astronaut.Add(newAstronaut);

                viewModels.Add(new ViewModel(newAstronaut, astronautImage));

                Task.Run(newAstronaut.Start);
            }
        }

        void GenerateMoney(int moneyNumber)
        {
            object[] doctorArgs = new object[]
           { (Action<string>)Notification,
                insurance.X,
                insurance.Y,
                astronaut,
                astronautsLocker };

            for (int i = 0; i < moneyNumber; i++)
            {
                foreach (var item in paymantTypes)
                {
                    Insurance newMoney = Activator.CreateInstance(item, doctorArgs) as Insurance;
                    newMoney.LastName = "DtLast" + i.ToString();
                    newMoney.FirstName = "DtFirst" + i.ToString();

                    viewModels.Add(new ViewModel(newMoney, moneyImage));

                    Task.Run(newMoney.Start);
                }
            }
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAstronautToolStripMenuItem.Enabled = true;
            AddMoneyToolStripMenuItem.Enabled = true;
            StartToolStripMenuItem.Enabled = false;
            AddRocetToolStripMenuItem.Enabled = true;

            painter = new Painter(pictureBox, Color.FromArgb(128, 255, 128),
               new Font(notificationTextBox.Font.FontFamily, 10f, notificationTextBox.Font.Style),
               viewObjects, viewObjectsLocker, viewModels, viewModelsLocker);

            // create buildings

            insurance = new ViewObject(insuranceImage);
            gym = new ViewObject(homeImage);

            SetBuildingsSize();

            // add hospital, stadium, gym
            viewObjects.Add(insurance);
            viewObjects.Add(gym);

            AddRocet("Заупуск 1");

            GenerateAstronauts(8);

            GenerateMoney(1);

            painter.Start();
        }

        private void addCompatitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStringDialog inputCompettionName = new InputStringDialog(new WordValidator(), "Введите имя соревнования");

            string name = "";

            if (inputCompettionName.ShowDialog() == DialogResult.OK)
                name = inputCompettionName.Value;

            InputStringDialog inputMaxParticipatingSportmansNumber = new InputStringDialog(new NotNegativeIntValidator(),
                "Введите максимальное количество спортсменов на соревновании");

            if (inputMaxParticipatingSportmansNumber.ShowDialog() == DialogResult.OK)
                AddRocet(name, Int32.Parse(inputMaxParticipatingSportmansNumber.Value));
            else
                AddRocet(name);
        }
    }
}