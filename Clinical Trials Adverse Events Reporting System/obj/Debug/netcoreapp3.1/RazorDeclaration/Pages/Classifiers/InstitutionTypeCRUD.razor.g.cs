// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Clinical_Trials_Adverse_Events_Reporting_System.Pages.Classifiers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\_Imports.razor"
using Clinical_Trials_Adverse_Events_Reporting_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\_Imports.razor"
using Clinical_Trials_Adverse_Events_Reporting_System.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\Pages\Classifiers\InstitutionTypeCRUD.razor"
using Clinical_Trials_Adverse_Events_Reporting_System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\Pages\Classifiers\InstitutionTypeCRUD.razor"
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/InstitutionType/{Action}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/InstitutionType/{Action}/{Id}")]
    public partial class InstitutionTypeCRUD : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\armin\source\repos\Clinical Trials Adverse Events Reporting System\Clinical Trials Adverse Events Reporting System\Pages\Classifiers\InstitutionTypeCRUD.razor"
       
    [Parameter]
    public string Action { get; set; }
    [Parameter]
    public string Id { get; set; }

    InstitutionType classifier = new InstitutionType();


    protected override async Task OnInitializedAsync()
    {
        if (Action == "Edit" || Action == "Delete")
        {
            classifier = await Task.Run(() => classifierRepository.GetById(Convert.ToInt32(Id)));
        }
        if (Action == "Delete")
        {
            DeleteClassifier();
        }
    }

    protected async void UpdateClassifier()
    {
        classifier.Modified = DateTime.UtcNow;
        await classifierRepository.Update(classifier);
        NavigationManager.NavigateTo("Classifiers/InstitutionType/Index");
    }

    protected async void CreateClassifier()
    {
        classifier.Created = DateTime.UtcNow;
        classifier.Modified = DateTime.UtcNow;
        await classifierRepository.Create(classifier);
        NavigationManager.NavigateTo("Classifiers/InstitutionType/Index");
    }

    protected async void DeleteClassifier()
    {
        await classifierRepository.Delete(classifier);
        NavigationManager.NavigateTo("Classifiers/InstitutionType/Index");
    }


    private void Cancel()
    {
        NavigationManager.NavigateTo("Classifiers/InstitutionType/Index");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassifierRepository<InstitutionType> classifierRepository { get; set; }
    }
}
#pragma warning restore 1591
