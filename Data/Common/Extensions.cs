namespace VirtualWaiter.Application.Data.Common
{
    public static partial class Extensions
    {
        public static string ToStringDecimal(this float? @this)
            => string.Format("${0:N2}", @this);

        public static string ToBoolString(this sbyte @this) => @this.Equals(1) ? "Activo" : "Inactivo";
    }
}
