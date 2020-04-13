# How to show or hide AccordionItem in Xamarin.Forms (SfAccordion)

You can show or hide the AccoridonItem in Xamarin.Forms [SfAccordion](https://help.syncfusion.com/xamarin/accordion/getting-started?) by handling the ViewModel bound collection with add or remove action.

You can also refer the following article.

https://www.syncfusion.com/kb/11383/how-to-show-or-hide-accordionitem-in-xamarin-forms-sfaccordion

**C#**

OnHideOrShow handler is used to show or hide the particular AccordionItem by updating the collection.

``` c#
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
```
