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
    public partial class MainForm : Form
    {
        Event[] eventBox;
        FormEventEditor formEditorEvent;
        XmlDocument doc;
        string XmlFileName;
        public string pathToXml;

        public MainForm()
        {
            InitializeComponent();
            XmlFileName = "MyEvents";           // Set from settings....
        }
// логирование
        public void log(string message)
        {
            textBoxLog.Text += "SmartPad #> " + message + "\r\n";
        }
// инициализация
        private void MainForm_Load(object sender, EventArgs e)
        {
            pathToXml = "events//" + XmlFileName + ".xml";
            loadEvents(pathToXml);
            fillEventPanel();
        }
// загрузка и обновление событий (2)
        private void loadEvents(string path)
        {
            doc = new XmlDocument();
            try
            {
                doc.Load(path);
            }
            catch (Exception exc)
            {
                log("Ошибка при загрузке XML: " + exc.Message);
                return;
            }

            XmlElement events = doc.DocumentElement;
            eventBox = new Event[events.ChildNodes.Count];
            if (events.ChildNodes.Count > 0)
            {
                byte j = 0;
                foreach (XmlNode event_node in events)
                {
                    Event ev = new Event();
                    ev.datestamp = event_node.Attributes.GetNamedItem("datestamp").Value;
                    foreach (XmlNode event_detail in event_node.ChildNodes)
                    {
                        if (event_detail.Name == "name")        ev.name = event_detail.InnerText;
                        if (event_detail.Name == "placement")   ev.placement = event_detail.InnerText;
                        if (event_detail.Name == "startdate")   ev.startDate = event_detail.InnerText;
                        if (event_detail.Name == "enddate")     ev.endDate = event_detail.InnerText;
                        if (event_detail.Name == "importance")  ev.importance = Convert.ToByte(event_detail.InnerText);
                        if (event_detail.Name == "description") ev.description = event_detail.InnerText;
                    }
                    eventBox[j] = ev;
                    j++;
                }
            }
        }

        public void updateEvents()
        {
            checkedListBoxEventsHeaders.Items.Clear();
            textBoxEventDescription.Text = "";
            loadEvents(pathToXml);
            fillEventPanel();
        }
// заполнение заголовков панели
        private void fillEventPanel()
        { 
            for (int i = 0; i < eventBox.Length; i++)
            {
                checkedListBoxEventsHeaders.Items.Add(eventBox[i].name);
            }
        }
// открытие формы для создания события
        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            openEditForm(EditorMode.create);
        }

        private void openEditForm(EditorMode mode)
        {
            if (formEditorEvent == null || formEditorEvent.IsDisposed)
            {
                formEditorEvent = new FormEventEditor(this);
            }
            formEditorEvent.Show();
            formEditorEvent.Focus();
            formEditorEvent.setMode(mode);
        }
// отображение деталей события
        private void checkedListBoxEventsHeaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxEventsHeaders.SelectedIndex != -1)
                textBoxEventDescription.Text = eventBox[checkedListBoxEventsHeaders.SelectedIndex].description;
        }
//
        private void MainForm_Resize(object sender, EventArgs e)
        {
            textBoxEventDescription.Height = checkedListBoxEventsHeaders.Height;
        }
// удаление события
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (checkedListBoxEventsHeaders.CheckedIndices.Count > 0)
            {
                foreach (int index in checkedListBoxEventsHeaders.CheckedIndices)
                {
                    XmlNode node = doc.SelectSingleNode("//event[@datestamp='" + eventBox[index].datestamp + "']");
                    try
                    {
                        node.ParentNode.RemoveChild(node);
                    }
                    catch (Exception exc)
                    {
                        log("Ошибка удаления события '" + eventBox[index].name + "': " + exc.Message);
                    }
                    doc.Save(pathToXml);
                }
                updateEvents();
            }
            else
                log("Для удаления отметьте события из списка!");
        }
// скроллинг логов
        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {
            textBoxLog.SelectionStart = textBoxLog.Text.Length;
            textBoxLog.ScrollToCaret();
        }
// редактирование событий
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (checkedListBoxEventsHeaders.CheckedIndices.Count > 0)
            {
                openEditForm(EditorMode.edit);
                // заполнение массива индексов событий для редактирования
                Event[] checkedEvents;
                checkedEvents = new Event[checkedListBoxEventsHeaders.CheckedIndices.Count];
                int j = 0;
                foreach (int index in checkedListBoxEventsHeaders.CheckedIndices)
                {
                    checkedEvents[j] = eventBox[index];
                    j++;
                }
                formEditorEvent.editEvents(checkedEvents);
                
                //updateEvents();
            }
            else
                log("Для редактирования выберите событие(-я) из списка!");
        }
    }

    public class Event
    {
        public string name;
        public string placement;
        public string startDate;
        public string endDate;
        public byte importance;
        public string description;
        public string datestamp;
    }
}
