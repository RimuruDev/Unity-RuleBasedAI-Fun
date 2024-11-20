namespace RimuruDev.Internal.Codebase.RuleBasedAi.Core
{
    public interface IRule
    {
        public bool CanExecute { get; }
        public void Execute();
    }
}