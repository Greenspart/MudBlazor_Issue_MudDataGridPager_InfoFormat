using Microsoft.Extensions.Localization;
using MudBlazor;

namespace DataGridInterceptorIssue.Model
{
    public class FrenchLocalizationInterceptor : ILocalizationInterceptor
    {
        public LocalizedString Handle(string key, params object[] arguments)
        {
            var translation = key switch
            {
                "MudDataGrid_AddFilter" => "Ajouter un filtre",
                "MudDataGrid_Apply" => "Appliquer",
                "MudDataGrid_Cancel" => "Annuler",
                "MudDataGrid_Clear" => "Effacer",
                "MudDataGrid_CollapseAllGroups" => "Réduire tous les groupes",
                "MudDataGrid_Column" => "Colonne",
                "MudDataGrid_Columns" => "Colonnes",
                "MudDataGrid_Contains" => "contient",
                "MudDataGrid_EndsWith" => "se termine par",
                "MudDataGrid_Equals" => "égal à",
                "MudDataGrid_EqualSign" => "=",
                "MudDataGrid_ExpandAllGroups" => "Développer tous les groupes",
                "MudDataGrid_False" => "faux",
                "MudDataGrid_Filter" => "Filtrer",
                "MudDataGrid_FilterValue" => "Valeur du filtre",
                "MudDataGrid_GreaterThanOrEqualSign" => ">=",
                "MudDataGrid_GreaterThanSign" => ">",
                "MudDataGrid_Group" => "Groupe",
                "MudDataGrid_Hide" => "Cacher",
                "MudDataGrid_HideAll" => "Tout cacher",
                "MudDataGrid_Is" => "est",
                "MudDataGrid_IsAfter" => "est après",
                "MudDataGrid_IsBefore" => "est avant",
                "MudDataGrid_IsEmpty" => "est vide",
                "MudDataGrid_IsNot" => "n'est pas",
                "MudDataGrid_IsNotEmpty" => "n'est pas vide",
                "MudDataGrid_IsOnOrAfter" => "est le ou après",
                "MudDataGrid_IsOnOrBefore" => "est le ou avant",
                "MudDataGrid_LessThanOrEqualSign" => "<=",
                "MudDataGrid_LessThanSign" => "<",
                "MudDataGrid_Loading" => "Chargement...",
                "MudDataGrid_MoveDown" => "Descendre",
                "MudDataGrid_MoveUp" => "Monter",
                "MudDataGrid_NotContains" => "ne contient pas",
                "MudDataGrid_NotEquals" => "différent de",
                "MudDataGrid_NotEqualSign" => "!=",
                "MudDataGrid_Operator" => "Opérateur",
                "MudDataGrid_RefreshData" => "Rafraîchir les données",
                "MudDataGrid_Save" => "Enregistrer",
                "MudDataGrid_ShowAll" => "Tout afficher",
                "MudDataGrid_Sort" => "Trier",
                "MudDataGrid_StartsWith" => "commence par",
                "MudDataGrid_True" => "vrai",
                "MudDataGrid_Ungroup" => "Dégrouper",
                "MudDataGrid_Unsort" => "Annuler le tri",
                "MudDataGrid_Value" => "Valeur",
                "MudDataGridPager_AllItems" => "Tous",
                //this doesn't work :(
                "MudDataGridPager_InfoFormat" => "{0}-{1} sur {2}",
                "MudDataGridPager_RowsPerPage" => "Lignes par page",
                _ => key
            };

            return new LocalizedString(key, translation);
        }
    }
}
