using Syncfusion.XForms.Accordion;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AccordionXamarin
{
   public class BehaviorClass : Behavior<ContentPage>
    {
        Contact deletedItem = null;
        SfAccordion accordion;
        Button HideOrShow;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            accordion = bindable.FindByName<SfAccordion>("Accordion");
            HideOrShow = bindable.FindByName<Button>("HideOrShow");
            HideOrShow.Clicked += OnHideOrShow;
        }
        private void OnHideOrShow(object sender, EventArgs e)
        {
            var items = (sender as Button).BindingContext as ViewModel;

            if (deletedItem == null)
            {
                deletedItem = items.ContactsInfo[2];
                items.ContactsInfo.RemoveAt(2);
            }
            else
            {
                items.ContactsInfo.Insert(2, deletedItem);
                deletedItem = null;
            }
        }
    }
}
