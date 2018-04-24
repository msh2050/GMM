using System;

class BooleanFormatter : IFormatProvider, ICustomFormatter
{
    readonly string _trueString;
    readonly string _falseString;

    public BooleanFormatter(string trueString, string falseString)
    {
        this._trueString = trueString;
        this._falseString = falseString;
    }
    public object GetFormat(System.Type type)
    {
        return this;
    }
    public string Format(string formatString, object arg, IFormatProvider formatProvider)
    {
        var formatValue = Convert.ToBoolean(arg);
        return formatValue ? _trueString : _falseString;
    }
}