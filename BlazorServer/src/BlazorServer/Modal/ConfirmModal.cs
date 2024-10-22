using BlazorServer.CustomComponents;

namespace BlazorServer.Modal
{
    public class ConfirmModal : BaseModal<bool>
    {

        public void Show()
        {
            IsVisible = true;
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
        //Set
        protected override void OnOk()
        {
            IsVisible = false;
            OnClose.InvokeAsync(true);
        }
        protected override void OnCancel()
        {
            IsVisible = false;
            OnClose.InvokeAsync(false);
        }

        //Set
        protected override void OnYes()
        {
            IsVisible = false;
            OnClose.InvokeAsync(true);
        }
        protected override void OnNo()
        {
            IsVisible = false;
            OnClose.InvokeAsync(false);
        }

        protected override void OnRetry()
        {
            throw new NotImplementedException();
        }

        protected override void OnAbort()
        {
            throw new NotImplementedException();
        }

        protected override void OnIgnore()
        {
            throw new NotImplementedException();

        }
    }
}