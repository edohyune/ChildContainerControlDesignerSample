

namespace ChildContainerControlDesignerSample
{
    using System.ComponentModel;
    using System.Windows.Forms;
    [Designer(typeof(pnlCtrlDesigner))]
    public partial class pnlCtrl : UserControl
    {
        public pnlCtrl()
        {
            InitializeComponent();
            TypeDescriptor.AddAttributes(this.contentsPanel,
                new DesignerAttribute(typeof(MyPanelDesigner)));
        }
        public string Title
        {
            get { return titleLabel.Text; }
            set { titleLabel.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentsPanel
        {
            get { return contentsPanel; }
        }
    }
}
