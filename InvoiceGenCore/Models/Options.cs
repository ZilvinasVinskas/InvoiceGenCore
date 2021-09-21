namespace InvoiceGenCore.Models
{
    public enum OrientationOption
    {
        Landscape = 0,
        Portrait = 1,
    }

    public enum PositionOption
    {
        Left = 0,
        Right = 1,
    }

    public enum SizeOption
    {
        A4 = 0,
        Letter = 1,
        Legal = 2,
    }

    public enum BillType
    {
        Invoice = 0,
        Receipt = 1
    }
}