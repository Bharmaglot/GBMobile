namespace Features.Shed.Upgrade
{

    internal interface IJumpUpgradeHandler
    {
        void Upgrade(IJumpUpgradeable jumpUpgradable);
    }
}
