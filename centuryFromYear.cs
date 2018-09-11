int centuryFromYear(int year) 
{
    int c;
    if ( year <= 100)
    {
        c = 1;
    }
    else if (year % 100 == 0)
    {
        c = year / 100;
    }
    else 
    {
        c = ((year / 100) + 1);
    }
    return c;
}
centuryFromYear(1905);

double centuryFromYear(double year) {
if (year % 100 > 0)
{
return Math.Truncate(year / 100)+1;
}
else
{
return (year / 100);
}
}