namespace Features.Shed.Upgrade
{
    internal interface IJumpUpgradeable
    {
        float JumpHeight { get; set; }
        void Restore();
    }
}