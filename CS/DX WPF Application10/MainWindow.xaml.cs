using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Serialization;

namespace DXWpfApplication {
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            InitializeComponent();

        }
        private void ButtonSave_Click(object sender, System.Windows.RoutedEventArgs e) {
            DXSerializer.Serialize(this,
                    "layout.xml", "DXWpfApplication",
                    new DXOptionsLayout() { AcceptNestedObjects = AcceptNestedObjects.VisualTreeOnly }
                );
        }
        private void ButtonRestore_Click(object sender, System.Windows.RoutedEventArgs e) {
            DXSerializer.Deserialize(this,
                    "layout.xml", "DXWpfApplication",
                    new DXOptionsLayout() { AcceptNestedObjects = AcceptNestedObjects.VisualTreeOnly }
                );
        }
    }
    class TestData {
        public string Text { get; set; }
        public int Number { get; set; }
    }
}
