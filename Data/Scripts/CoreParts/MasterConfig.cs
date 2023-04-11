
namespace Scripts
{
    partial class Parts
    {
        internal Parts()
        {
            // naming convention: WeaponDefinition Name
            //SA_HMI_ERGaussRF
            // Enable your definitions using the follow syntax:
            // PartDefinitions(Your1stDefinition, Your2ndDefinition, Your3rdDefinition);
            // PartDefinitions includes both weapons and phantoms
            PartDefinitions(
            HAS_Assault,
            HAS_Thanatos,
            HAS_Alecto,
            HAS_Mammon,
            HAS_Nott,
            HAS_Hecate,
            HAS_Twin,
            HAS_Esper,
            HAS_Vulcan
            );
            ArmorDefinitions();
            SupportDefinitions();
            UpgradeDefinitions();
        }
    }
}
