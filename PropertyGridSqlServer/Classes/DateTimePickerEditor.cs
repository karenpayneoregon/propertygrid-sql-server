using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PropertyGridSqlServer.Classes
{
    public class DateTimePickerEditor : UITypeEditor
    {

        IWindowsFormsEditorService editorService;
        readonly DateTimePicker picker = new DateTimePicker();

        /// <summary>
        /// Set date format for display in PropertyGrid
        /// </summary>
        public DateTimePickerEditor()
        {
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = @"MM/dd/yyyy";
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (provider != null)
            {
                editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            }

            if (editorService != null)
            {
                picker.Value = (DateTime)value;
                editorService.DropDownControl(picker);
                value = picker.Value;
            }

            return value;
        }
    }
}
