using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SmartPad
{
    public partial class FormEventEditor : Form
    {
        MainForm mainForm;
        XmlTextWriter textWriter;
        XmlDocument doc;
        XmlNode eventNode;
        EditorMode mode;
        Event[] editableEvents;
        int indexOfEditableEvent;

        public FormEventEditor(MainForm instance)
        {
            InitializeComponent();
            mainForm = instance;
        }

        public void setMode(EditorMode mode)
        {
            this.mode = mode;
            if (this.mode == EditorMode.create)
                groupBoxEventNavigator.Visible = false;
            else
                groupBoxEventNavigator.Visible = true;
        }

        private void appendChild(string name, string innerText, XmlNode evNode)
        {
            XmlNode node = doc.CreateElement(name);
            node.InnerText = innerText;
            evNode.AppendChild(node);
        }
// сохранение данных в xml
        private void save()
        {
            doc = new XmlDocument();
            doc.Load(mainForm.pathToXml);

            if (mode == EditorMode.create)
            {
                eventNode = doc.CreateElement("event");
                XmlAttribute eventNodeAttribute = doc.CreateAttribute("datestamp");
                eventNodeAttribute.Value = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + "." + DateTime.Now.Millisecond;
                eventNode.Attributes.Append(eventNodeAttribute);
                doc.DocumentElement.AppendChild(eventNode);

                appendChild("name", textBoxName.Text, eventNode);
                appendChild("placement", textBoxPlacement.Text, eventNode);
                appendChild("startdate", dateTimePickerStart.Value.ToShortDateString(), eventNode);
                if (checkBoxNoViewEndDate.CheckState != CheckState.Checked)
                    appendChild("enddate", dateTimePickerEnd.Value.ToShortDateString(), eventNode);
                appendChild("importance", trackBarImportance.Value.ToString(), eventNode);
                appendChild("description", textBoxDescription.Text, eventNode);

                try
                {
                    textWriter = new XmlTextWriter(mainForm.pathToXml, Encoding.UTF8);
                }
                catch (Exception exc)
                {
                    mainForm.log(exc.Message);
                    return;
                }

                textWriter.WriteStartDocument();
                textWriter.WriteStartElement("events");
                textWriter.WriteEndElement();
                textWriter.Close();
            }

            if (mode == EditorMode.edit)
            {
                // поиск и изменение информации в XML
                XmlNode Event = doc.SelectSingleNode("//event[@datestamp='" + editableEvents[indexOfEditableEvent].datestamp + "']");
                foreach (XmlNode node in Event.ChildNodes)
                {
                    if (node.Name == "name")        node.InnerText = textBoxName.Text;
                    if (node.Name == "placement")   node.InnerText = textBoxPlacement.Text;
                    if (node.Name == "startdate")   node.InnerText = Convert.ToString(dateTimePickerStart.Value);
                    if (node.Name == "enddate")     node.InnerText = Convert.ToString(dateTimePickerEnd.Value);
                    if (node.Name == "importance")  node.InnerText = Convert.ToString(trackBarImportance.Value);
                    if (node.Name == "description") node.InnerText = textBoxDescription.Text;
                }
            }

            doc.Save(mainForm.pathToXml);
            mainForm.updateEvents();
        }
// вызов процедуры сохранения данных
        private void buttonSave_Click(object sender, EventArgs e)
        {
            save();
            mainForm.log("Событие '" + textBoxName.Text + "' сохранено!");
        }
// закрытие формы
        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            Close();
        }
// заполнение полей для редактирования
        public void fillFieldsEdit(Event ev)
        {
            textBoxName.Text = ev.name;
            textBoxPlacement.Text = ev.placement;
            dateTimePickerStart.Value = Convert.ToDateTime(ev.startDate);

            if (ev.endDate != null)
            {
                dateTimePickerEnd.Value = Convert.ToDateTime(ev.endDate);
                checkBoxNoViewEndDate.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBoxNoViewEndDate.CheckState = CheckState.Checked;
            }
            
            trackBarImportance.Value = ev.importance;
            textBoxDescription.Text = ev.description;
        }
// редактирование событий
        public void editEvents(Event [] evs)
        {
            indexOfEditableEvent = 0;
            editableEvents = evs;
            labelCurrentIndex.Text = (indexOfEditableEvent + 1).ToString() + "/" + editableEvents.Length.ToString();
            fillFieldsEdit(editableEvents[indexOfEditableEvent]);
        }
// обработчик события выбора чекбокса NoViewEndDate
        private void checkBoxNoViewEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoViewEndDate.CheckState == CheckState.Checked)
                dateTimePickerEnd.Enabled = false;
            else
                dateTimePickerEnd.Enabled = true;
        }
// изменение индекса редактируемого события
        private void buttonPrevEvent_Click(object sender, EventArgs e)
        {
            if (indexOfEditableEvent > 0)
                indexOfEditableEvent--;
            else
                indexOfEditableEvent = editableEvents.Length - 1;
            fillFieldsEdit(editableEvents[indexOfEditableEvent]);
            labelCurrentIndex.Text = (indexOfEditableEvent + 1).ToString() + "/" + editableEvents.Length.ToString();
        }

        private void buttonNextEvent_Click(object sender, EventArgs e)
        {
            if (indexOfEditableEvent < editableEvents.Length - 1)
                indexOfEditableEvent++;
            else
                indexOfEditableEvent = 0;
            fillFieldsEdit(editableEvents[indexOfEditableEvent]);
            labelCurrentIndex.Text = (indexOfEditableEvent + 1).ToString() + "/" + editableEvents.Length.ToString();
        }
    }

    public enum EditorMode { create, edit }
}
