namespace Features.Shed.Upgrade
{
    internal class StubJumpUpgradeHandler : IJumpUpgradeHandler
    {
        public static readonly IJumpUpgradeHandler Default = new StubJumpUpgradeHandler();

        public void Upgrade(IJumpUpgradeable upgradable) { }
    }
}