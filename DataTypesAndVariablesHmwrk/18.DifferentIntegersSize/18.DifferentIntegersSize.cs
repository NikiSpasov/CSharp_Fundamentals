using System;

class Program
{
    static void Main()
    {
        string num = Console.ReadLine();
        try
        {
            var a = Convert.ToSByte(num);
            if (a > -1)
            {
                Console.WriteLine(a + " can fit in:");
                Console.WriteLine("* sbyte");
                Console.WriteLine("* byte");
                Console.WriteLine("* short");
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long");
                return;
            }
            else
            {
                Console.WriteLine(a + " can fit in:");
                Console.WriteLine("* byte");
                Console.WriteLine("* short");
                Console.WriteLine("* int");
                Console.WriteLine("* long");
                return;
            }

        }
        catch (Exception)
        {
            try
            {
                var b = Convert.ToByte(num);
                Console.WriteLine(b + " can fit in:");
                Console.WriteLine("* byte");
                Console.WriteLine("* short");
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long");
                return;
            }
            catch (Exception)
            {
                try
                {
                    var c = Convert.ToInt16(num);
                    if (c < 0)
                    {
                        Console.WriteLine(c + " can fit in:");
                        Console.WriteLine("* short");
                        Console.WriteLine("* int");
                        Console.WriteLine("* long");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(c + " can fit in:");
                        Console.WriteLine("* short");
                        Console.WriteLine("* ushort");
                        Console.WriteLine("* int");
                        Console.WriteLine("* uint");
                        Console.WriteLine("* long");
                        return;
                    }

                }
                catch (Exception)
                {

                    try
                    {
                        var d = Convert.ToUInt16(num);
                        Console.WriteLine(d + " can fit in:");
                        Console.WriteLine("* ushort");
                        Console.WriteLine("* int");
                        Console.WriteLine("* uint");
                        Console.WriteLine("* long");
                        return;
                    }
                    catch (Exception)
                    {
                        try
                        {
                            var e = Convert.ToInt32(num);
                            if (e > -1)
                            {
                                Console.WriteLine(e + " can fit in:");
                                Console.WriteLine("* int");
                                Console.WriteLine("* uint");
                                Console.WriteLine("* long");
                                return;
                            }
                            else
                            {
                                Console.WriteLine(e + " can fit in:");
                                Console.WriteLine("* int");
                                Console.WriteLine("* long");
                                return;
                            }
                           
                        }
                        catch (Exception)
                        {
                            try
                            {
                                var f = Convert.ToUInt32(num);
                                Console.WriteLine(f + " can fit in:");
                                Console.WriteLine("* uint");
                                Console.WriteLine("* long");
                                return;
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    var g = Convert.ToInt64(num);
                                    Console.WriteLine(g + " can fit in:");
                                    Console.WriteLine("* long");
                                    return;
                                }
                                catch (Exception)
                                {

                                    Console.WriteLine(num + " can't fit in any type");
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}

//sbyte < byte < short < ushort < int < uint < long
//var b = Convert.ToByte(num);
//var c = Convert.ToInt16(num);
//var d = Convert.ToUInt16(num);
//var e = Convert.ToInt32(num);
//var f = Convert.ToUInt32(num);
//var g = Convert.ToInt64(num);

//string[] types = { "sbyte", "byte", "short", "ushort", "int", "uint", "long" };

//            for (int i = cnt; i<types.Length; i++)
//            {
//                Console.WriteLine(types[i]);

//            }
// Console.WriteLine("can't fit in any type");