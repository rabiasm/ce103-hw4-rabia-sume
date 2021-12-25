using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll;
using System.Text;

namespace ce103_hw4_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_1()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(10);
            Assert.AreEqual(result, 34);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_1()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(10);
            Assert.AreEqual(result, 34);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_1()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(10);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(10);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_2()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(30);
            Assert.AreEqual(result, 514229);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_2()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(30);
            Assert.AreEqual(result, 514229);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_2()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(30);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(30);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_3()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(3);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_3()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(3);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_3()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(3);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(3);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_strrev_cs_test_1()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs("Computer"), "retupmoC");
        }
  
        [TestMethod]
        public void ce103_strrev_cs_test_2()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs("New World"), "dlroW weN");
        }
    
        [TestMethod]
        public void ce103_strrev_cs_test_3()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs("HelloWorld"), "dlroWolleH");         
        }
     
        [TestMethod]
        public void ce103_strlen_cs_test_1()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs("Program"), 7);
        }

        [TestMethod]
        public void ce103_strlen_cs_test_2()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs("Database Systems"), 16);
        }
    
        [TestMethod]
        public void ce103_strlen_cs_test_3()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs("Artificial Intelligence"), 23);
        }

        [TestMethod]
        public void ce103_strcat_cs_test_1()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs("Hello","World"),"HelloWorld");
        }
  
        [TestMethod]
        public void ce103_strcat_cs_test_2()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs("Computer","Virus"),"ComputerVirus");
        }
 
        [TestMethod]
        public void ce103_strcat_cs_test_3()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs("Operating","System"),"OperatingSystem");
        }

        [TestMethod]
        public void ce103_strcmp_cs_test_1()
        {
            Class1 strcmp = new Class1();
            Assert.AreEqual(strcmp.ce103_strcmp_cs("Computer", "Computer"), 0);
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_test_2()
        {
            Class1 strcmp = new Class1();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Computer", "Engineering"), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_test_3()
        {
            Class1 strcmp = new Class1();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Hello", "World"), 0);
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_1()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Hi"), "Hi");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_2()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Engineering"), "Engineering");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_3()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Software", "Hello"), "Hello");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_test_1()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("Computer"), "retupmoC");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_1()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("Computer"), "retupmoC", Strrev.ce103_strrev_cs_imported("Computer"), "retupmoC");
        }
 
        [TestMethod]
        public void ce103_strrev_cs_imported_test_2()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("New World"), "dlroW weN");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_2()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("New World"), "dlroW weN", Strrev.ce103_strrev_cs_imported("New World"), "dlrow weN");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_test_3()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("HelloWorld"), "dlroWolleH");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_3()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("HelloWorld"), "dlroWolleH", Strrev.ce103_strrev_cs_imported("HelloWorld"), "dlroWolleH");
        }
       
        [TestMethod]
        public void ce103_strcat_cs_imported_test_1()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Hello", "World"), "HelloWorld");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_1()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("Hello", "World"), "HelloWorld", Strcat.ce103_strcat_cs_imported("Hello", "World"), "HelloWorld");
        }
      
        [TestMethod]
        public void ce103_strcat_cs_imported_test_2()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Computer", "Virus"), "ComputerVirus");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_2()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("Computer", "Virus"), "ComputerVirus", Strcat.ce103_strcat_cs_imported("Computer", "Virus"), "ComputerVirus");
        }
        
        [TestMethod]
        public void ce103_strcat_cs_imported_test_3()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Operating", "System"), "OperatingSystem");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_3()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("Operating", "System"), "OperatingSystem", Strcat.ce103_strcat_cs_imported("Operating", "System"), "OperatingSystem");
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_test_1()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Program"), 7);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_1()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs("Program"), 7, Strlen.ce103_strlen_cs_imported("Program"));
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_test_2()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Database Systems"), 16);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_2()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs("Database Systems"), 16, Strlen.ce103_strlen_cs_imported("Database Systems"));
        }
  
        [TestMethod]
        public void ce103_strlen_cs_imported_test_3()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Artificial Intelligence"), 23);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_3()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs("Artificial Intelligence"), 23, Strlen.ce103_strlen_cs_imported("Artificial Intelligence"));
        }

        [TestMethod]
        public void ce103_strcmp_cs_imported_test_1()
        {
            Class2 strcmp = new Class2();
            Assert.AreEqual(strcmp.ce103_strcmp_cs_imported("Computer", "Computer"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_1()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreEqual(strcmp.ce103_strcmp_cs("Computer", "Computer"), 0, Strcmp.ce103_strcmp_cs_imported("Computer", "Computer"));
        }
     
        [TestMethod]
        public void ce103_strcmp_cs_imported_test_2()
        {
            Class2 strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported("Computer", "Engineering"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_2()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Computer", "Engineering"), 0, Strcmp.ce103_strcmp_cs_imported("Computer", "Engineering"));
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_imported_test_3()
        {
            Class2 strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported("Hello", "World"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_3()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Hello", "World"), 0, Strcmp.ce103_strcmp_cs_imported("Hello", "World"));
        }

        [TestMethod]
        public void ce103_strcpy_cs_imported_test_1()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Computer", "Hi"), "Hi");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_1()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Hi"), "Hi", Strcpy.ce103_strcpy_cs_imported("Computer", "Hi"), "Hi");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_2()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Computer", "Engineering"), "Engineering");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_2()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Computer", "Engineering"), "Engineering", Strcpy.ce103_strcpy_cs_imported("Computer", "Engineering"), "Engineering");
        }
     
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_3()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Software", "Hello"), "Hello");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_3()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Software", "Hello"), "Hello", Strcpy.ce103_strcpy_cs_imported("Software", "Hello"), "Hello");
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test1()
        {
            Class1 bin2hex = new Class1();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test1()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test1()
        {
            Class1 bin2hex = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test2()
        {
            Class1 bin2hex = new Class1();
            byte[] bin = { 0x11, 0x11, 0x11, 0x11, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test2()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0x11, 0x11, 0x11, 0x11, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test2()
        {
            Class1 bin2hex = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xBB, 0xFB, 0xCD, 0x23, 0x43, 0x10 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test3()
        {
            Class1 bin2hex = new Class1();
            byte[] bin = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A', 'F', 'A' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test3()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test3()
        {
            Class1 bin2hex = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD, 0xDD };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);
            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test1()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "1313131313131313";
            byte[] expectedArr = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test1()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "AAFBCD234324";
            byte[] expectedArr = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test1()
        {
            Class2 imported = new Class2();
            Class1 hex2bin = new Class1();
            string hexstring = "FFFFFFFFFF";

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test2()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "1111111111111111";
            byte[] expectedArr = { 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test2()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "2348975982379872239487";
            byte[] expectedArr = { 0x23, 0x48, 0x97, 0x59, 0x82, 0x37, 0x98, 0x72, 0x23, 0x94, 0x87 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test2()
        {
            Class2 imported = new Class2();
            Class1 hex2bin = new Class1();
            string hexstring = "ABCDEAEC";
            byte[] expectedArr = { 0xAB, 0xCD, 0xEA, 0xEC };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test3()
        {
            Class1 hex2bin = new Class1();
            string hexstring = "FAFAFAFAFAFAFAFA";
            byte[] expectedArr = { 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA, 0xFA };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test3()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "1313131313131313131313";
            byte[] expectedArr = { 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13, 0x13 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test3()
        {
            Class2 imported = new Class2();
            Class1 hex2bin = new Class1();
            string hexstring = "91423FC23A234832FA";
            byte[] expectedArr = { 0x91, 0x42, 0x3F, 0xC2, 0x3A, 0x23, 0x48, 0x32, 0xFA };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
    }
}
