
using BlazorServer.CustomKomponents.Enums;
using Microsoft.AspNetCore.Components;

using Microsoft.AspNetCore.Components.Web;

namespace BlazorServer.CustomComponents
{
    public partial class BaseModal<T> : ComponentBase where T : notnull
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        [EditorRequired]
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public string Message { get; set; } = string.Empty;

        [Parameter]
        [EditorRequired]
        public ModalButtons Buttons { get; set; } = ModalButtons.Ok;

        [Parameter]
        public ControlComponent Orientation { get; set; } = ControlComponent.Left;

        /// <summary>
        /// Zum Anzeigen des Modals
        /// </summary>
        [Parameter]
        public bool IsVisible { get; set; }

        /// <summary>
        /// Zusätzliche EventCallback, die beim Schließen des Modals aufgerufen wird
        /// </summary>
        [Parameter]
        public EventCallback<T> OnClose { get; set; }

        [Parameter]
        public int ModalWidth { get; set; } = 50;

        [Parameter]
        public RenderFragment? ButtonContent { get; set; } = null;

        protected void Close()
        {
            IsVisible = false;
            OnClose.InvokeAsync();
        }

        protected virtual void OnOk() => Close();
        protected virtual void OnCancel() => Close();
        protected virtual void OnYes() => Close();
        protected virtual void OnNo() => Close();
        protected virtual void OnRetry() => Close();
        protected virtual void OnAbort() => Close();
        protected virtual void OnIgnore() => Close();

        protected string GetButtonOrientations()
        {
            return Orientation switch
            {
                ControlComponent.Left => "justify-content-start",
                ControlComponent.Right => "justify-content-end",
                ControlComponent.Top => "justify-content-center",
                ControlComponent.Bottom => "justify-content-center",
                _ => "justify-content-normal"
            };
        }

        protected void HandleKeyDown(KeyboardEventArgs e)
        {
            if (e.Key == "Escape")
            {
                Close();
            }
        }
    }

}

