namespace suicide_overview.src.model.DecisionTreeClassifier
{
    internal class Decision
    {
        public string variableName { get; set; }

        public int typeVariable { get; set; }

        public object value { get; set; }

        public Decision(string variableName, int typeVariable, object value)
        {
            this.variableName = variableName;
            this.typeVariable = typeVariable;
            this.value = value;
        }
    }
}