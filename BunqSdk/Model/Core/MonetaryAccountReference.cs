using Bunq.Sdk.Model.Generated.Object;

namespace Bunq.Sdk.Model.Core
{
    /// <summary>
    /// Adapter required to provide compatibility between the two types used to refer to Monetary Accounts: Pointers in
    /// requests and Monetary Account Labels in responses.
    /// </summary>
    public class MonetaryAccountReference
    {
        public PointerObject Pointer { get; private set; }
        public LabelMonetaryAccountObject LabelMonetaryAccount { get; private set; }

        public MonetaryAccountReference(PointerObject pointer)
        {
            Pointer = pointer;
        }

        public MonetaryAccountReference(LabelMonetaryAccountObject labelMonetaryAccount)
        {
            LabelMonetaryAccount = labelMonetaryAccount;
        }
    }
}