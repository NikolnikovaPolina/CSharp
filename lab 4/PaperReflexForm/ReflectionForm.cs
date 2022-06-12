using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using PaperModel;
using SharedForm;
namespace PaperReflexForm
{
    public partial class ReflectionForm : Form
    {
        Assembly asm;
        IEnumerable<Type> types;

        Type type;
        object? curObject;

        MethodInfo method;
        object[] methodParameters;

        public ReflectionForm()
        {
            InitializeComponent();
            choiceMethodBox.Enabled = false;
            createClassButton.Enabled = false;
            fillParametersButton.Enabled = false;
            executeMethodButton.Enabled = false;
        }

        private void UpdateClassFields()
        {
            classFieldsBox.Items.Clear();
            foreach (var item in type.GetProperties())
            {
                classFieldsBox.Items.Add(item.Name + ": " + item.GetValue(curObject));
            }
        }

        private void ReflectionForm_Load(object sender, EventArgs e)
        {
            asm = Assembly.Load("PaperModel");

            types = asm.GetTypes().Where(type => !type.IsAbstract && type.GetInterface("IPaper") != null);
            choiceClassBox.Items.AddRange(types.Select(type => type.Name).ToArray());
        }

        private void choiceClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = types.First(t => t.Name == choiceClassBox.SelectedItem.ToString());
            curObject = null;
            choiceMethodBox.Enabled = true;
            createClassButton.Enabled = true;
            IEnumerable<string> objectMethods = new object().GetType().GetMethods().Select(method => method.Name);

            choiceMethodBox.Items.Clear();

            choiceMethodBox.Items.
                AddRange(type.GetMethods()
                .Where(methInfo => !objectMethods.Contains(methInfo.Name) && methInfo.Name.Substring(0, 4) != "get_" && methInfo.Name.Substring(0, 4) != "set_")
                .Select(t => t.Name).ToArray());
        }

        private void createClassButton_Click(object sender, EventArgs e)
        {
            executeMethodButton.Enabled = true;
            fillParametersButton.Enabled = true;

            object newObject = Activator.CreateInstance(type);

            foreach (var it in newObject.GetType().GetProperties())
            {
                if (it.PropertyType.Name == "Int32")
                {
                    InputInt inputForm = new InputInt("Введите " + it.Name);
                    inputForm.ShowDialog();
                    int number = inputForm.number;
                    it.SetValue(newObject, number);
                }
                else if (it.PropertyType.Name == "Double")
                {
                    InputDouble inputForm = new InputDouble("Введите " + it.Name);
                    inputForm.ShowDialog();
                    double number = inputForm.number;
                    it.SetValue(newObject, number);
                }
                else
                {
                    InputString inputForm = new InputString("Введите " + it.Name);
                    inputForm.ShowDialog();
                    string str = inputForm.str;
                    it.SetValue(newObject, str);
                }
            }
            curObject = newObject;
            UpdateClassFields();
        }

        private void fillParametersButton_Click(object sender, EventArgs e)
        {
            if (choiceMethodBox.SelectedIndex != -1)
            {
                parametersBox.Items.Clear();
                if (method.GetParameters().Length != 0)
                {
                    var parametersList = new List<object>();

                    foreach (var it in method.GetParameters())
                    {
                        if (it.ParameterType.Name == "Int32")
                        {
                            InputInt inputForm = new InputInt("Введите " + it.Name);
                            inputForm.ShowDialog();
                            int number = inputForm.number;
                            parametersList.Add(number);
                            parametersBox.Items.Add(it.Name + ": " + number);

                        }
                        else if (it.ParameterType.Name == "Double")
                        {
                            InputDouble inputForm = new InputDouble("Введите " + it.Name);
                            inputForm.ShowDialog();
                            double number = inputForm.number;
                            parametersList.Add(number);
                            parametersBox.Items.Add(it.Name + ": " + number);
                        }
                        else
                        {
                            InputString inputForm = new InputString("Введите " + it.Name);
                            inputForm.ShowDialog();
                            string str = inputForm.str;
                            parametersList.Add(str);
                            parametersBox.Items.Add(it.Name + ": " + str);
                        }
                    }
                    methodParameters = parametersList.Select(x => x).ToArray();
                    executeMethodButton.Enabled = true;

                }
                else
                {
                    methodParameters = null;
                }
            }
        }

        private void executeMethodButton_Click(object sender, EventArgs e)
        {
            if (choiceMethodBox.SelectedIndex != -1 && curObject != null)
            {
                if (method.GetParameters().Length != 0 && methodParameters == null)
                {
                    MessageBox.Show("Введите параметры метода!", "Ошибка");
                }
                else
                {
                    if (method.ReturnType == typeof(void))
                    {
                        method.Invoke(curObject, methodParameters);
                    }
                    else
                    {
                        MessageBox.Show(method.Invoke(curObject, methodParameters).ToString());
                    }

                    UpdateClassFields();
                }
            }
            else
            {
                MessageBox.Show("Для начала необходимо создать класс и выбрать метод.", "Ошибка");
            }
        }

        private void choiceMethodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<string> methods = (new object()).GetType().GetMethods().Select(method => method.Name);

            method = type.GetMethods()
                .First(m => !methods.Contains(m.Name)
                && m.Name.Substring(0, 4) != "get_"
                && m.Name.Substring(0, 4) != "set_"
                && m.Name == choiceMethodBox.SelectedItem.ToString());

            if (method.GetParameters().Length == 0)
            {
                methodParameters = null;
                fillParametersButton.Enabled = false;
            }
            else
            {
                fillParametersButton.Enabled = true;
            }
        }
    }
}
