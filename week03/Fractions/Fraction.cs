using System;
/* 
Class: Fraction
Attributes:
* _top: int
* _bottom: int

Constructors:
* Fraction()
* Fraction(wholeNumber: int)
* Fraction(top: int, bottom: int)

Getters and Setters:
* GetTop()
* SetTop(top: int)
* GetBottom()
* SetBottom(bottom: int)

Behaviors:
* GetFractionString(): string
* GetDecimalValue(): double
*/

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        //string Text = $"{_top}/{_bottom}";
        //return Text; 
        // or it can also be written
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}



