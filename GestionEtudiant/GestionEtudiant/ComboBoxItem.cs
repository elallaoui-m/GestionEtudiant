namespace GestionEtudiant
{
    internal class ComboBoxItem
    {
        private int Value;
        private string Text;

        public ComboBoxItem(int Value, string Text)
        {
            this.Text = Text;
            this.Value = Value;
        }

        public int Value1 { get => Value; set => Value = value; }

        public override string ToString()
        {
            return Text;
        }
    }
}