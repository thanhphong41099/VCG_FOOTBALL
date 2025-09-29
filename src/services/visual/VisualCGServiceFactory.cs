using System;

namespace VLeague.Services.Visual
{
    public static class VisualCGServiceFactory
    {
        public static IVisualCGService Create(VisualSDKType sdkType)
        {
            switch (sdkType)
            {
                case VisualSDKType.K3DAsyncEngine:
                    return new K3DVisualCGService();
                case VisualSDKType.KarismaSDK:
                    return new KarismaVisualCGService();
                default:
                    throw new ArgumentOutOfRangeException(nameof(sdkType), sdkType, null);
            }
        }
    }
}
