
namespace WinFormsMvpExample.Infrestructure
{
    public abstract class BasePresenter<TView>
        where TView : IView
    {
        public TView View { get; }

        protected BasePresenter(TView view) => View = view;
    }
}
