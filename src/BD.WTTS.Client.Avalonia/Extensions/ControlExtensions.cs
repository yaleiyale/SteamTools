namespace BD.WTTS.UI;

public static class ControlExtensions
{
    public static void SetViewModel<T>(this Control c, bool useCache = true) where T : ViewModelBase
    {
        if (c.DataContext == null || c.DataContext.GetType() != typeof(T))
        {
            T cx;

            if (useCache)
                cx = IViewModelManager.Instance.Get<T>();
            else
                cx = Activator.CreateInstance<T>();

            c.DataContext = cx;
        }
    }
}
