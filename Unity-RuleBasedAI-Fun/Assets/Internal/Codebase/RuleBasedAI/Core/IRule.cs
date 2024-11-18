namespace RimuruDev.Internal.Codebase.RuleBasedAI.Core
{
    public interface IRule
    {
        public bool CanExecute { get; }
        public void Execute();
    }
}