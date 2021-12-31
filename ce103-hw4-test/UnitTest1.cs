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
            int result = fibo.ce103_fibonacciNumber_cs(22);
            Assert.AreEqual(result, 10946);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_1()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(22);
            Assert.AreEqual(result, 10946);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_1()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(22);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(22);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_2()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(19);
            Assert.AreEqual(result, 2584);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_2()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(19);
            Assert.AreEqual(result, 2584);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_2()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(19);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(19);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_3()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(2);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_3()
        {
            Class2 fibo = new Class2();
            int result = fibo.ce103_fibonacciNumber_cs_imported(2);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_3()
        {
            Class1 fibo = new Class1();
            int result = fibo.ce103_fibonacciNumber_cs(2);
            Class2 fiboo = new Class2();
            int result2 = fiboo.ce103_fibonacciNumber_cs_imported(2);
            Assert.AreEqual(result, result2);
        }
        [TestMethod]
        public void ce103_strrev_cs_test_1()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs("Sume"), "emuS");
        }
  
        [TestMethod]
        public void ce103_strrev_cs_test_2()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs("Rabia"), "aibaR");
        }
    
        [TestMethod]
        public void ce103_strrev_cs_test_3()
        {
            Class1 strrev = new Class1();
            Assert.AreEqual(strrev.ce103_strrev_cs("Blockchain"), "niahckcolB");         
        }
     
        [TestMethod]
        public void ce103_strlen_cs_test_1()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs("Password"), 8);
        }

        [TestMethod]
        public void ce103_strlen_cs_test_2()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs("Software"), 8);
        }
    
        [TestMethod]
        public void ce103_strlen_cs_test_3()
        {
            Class1 strlen = new Class1();
            Assert.AreEqual(strlen.ce103_strlen_cs("Human Computer Interaction"), 26);
        }

        [TestMethod]
        public void ce103_strcat_cs_test_1()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs("Source","File"),"SourceFile");
        }
  
        [TestMethod]
        public void ce103_strcat_cs_test_2()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs("Resource","File"),"ResourceFile");
        }
 
        [TestMethod]
        public void ce103_strcat_cs_test_3()
        {
            Class1 strcat = new Class1();
            Assert.AreEqual(strcat.ce103_strcat_cs("Header","File"),"HeaderFile");
        }

        [TestMethod]
        public void ce103_strcmp_cs_test_1()
        {
            Class1 strcmp = new Class1();
            Assert.AreEqual(strcmp.ce103_strcmp_cs("References", "References"), 0);
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_test_2()
        {
            Class1 strcmp = new Class1();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Rabia", "Süme"), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_test_3()
        {
            Class1 strcmp = new Class1();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Bad", "Laptop"), 0);
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_1()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("File", "Hardware"), "Hardware");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_2()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Fundemental", "Information"), "Information");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_3()
        {
            Class1 strcpy = new Class1();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("View", "Class"), "Class");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_test_1()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("Sume"), "emuS");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_1()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("Sume"), "emuS", Strrev.ce103_strrev_cs_imported("Sume"), "emuS");
        }
 
        [TestMethod]
        public void ce103_strrev_cs_imported_test_2()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("Rabia"), "aibaR");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_2()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("Rabia"), "aibaR", Strrev.ce103_strrev_cs_imported("New World"), "dlrow weN");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_test_3()
        {
            Class2 strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs_imported("Blockchain"), "niahckcolB");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_3()
        {
            Class1 strrev = new Class1();
            Class2 Strrev = new Class2();
            Assert.AreEqual(strrev.ce103_strrev_cs("Blockchain"), "niahckcolB", Strrev.ce103_strrev_cs_imported("Blockchain"), "niahckcolB");
        }
       
        [TestMethod]
        public void ce103_strcat_cs_imported_test_1()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Source", "File"), "SourceFile");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_1()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("Source", "File"), "SourceFile", Strcat.ce103_strcat_cs_imported("Source", "File"), "SourceFile");
        }
      
        [TestMethod]
        public void ce103_strcat_cs_imported_test_2()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Resource", "File"), "ResourceFile");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_2()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("Resource", "File"), "ResourceFile", Strcat.ce103_strcat_cs_imported("Resource", "File"), "ResourceFile");
        }
        
        [TestMethod]
        public void ce103_strcat_cs_imported_test_3()
        {
            Class2 strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs_imported("Header", "File"), "HeaderFile");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_3()
        {
            Class1 strcat = new Class1();
            Class2 Strcat = new Class2();
            Assert.AreEqual(strcat.ce103_strcat_cs("Header", "File"), "HeaderFile", Strcat.ce103_strcat_cs_imported("Header", "File"), "HeaderFile");
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_test_1()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Password"), 8);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_1()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs("Password"), 8, Strlen.ce103_strlen_cs_imported("Password"));
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_test_2()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Software"), 8);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_2()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs("Software"), 8, Strlen.ce103_strlen_cs_imported("Software"));
        }
  
        [TestMethod]
        public void ce103_strlen_cs_imported_test_3()
        {
            Class2 strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs_imported("Human Computer Interaction"), 26);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_3()
        {
            Class1 strlen = new Class1();
            Class2 Strlen = new Class2();
            Assert.AreEqual(strlen.ce103_strlen_cs("Human Computer Interaction"), 26, Strlen.ce103_strlen_cs_imported("Human Computer Interaction"));
        }

        [TestMethod]
        public void ce103_strcmp_cs_imported_test_1()
        {
            Class2 strcmp = new Class2();
            Assert.AreEqual(strcmp.ce103_strcmp_cs_imported("References", "References"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_1()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreEqual(strcmp.ce103_strcmp_cs("References", "References"), 0, Strcmp.ce103_strcmp_cs_imported("References", "References"));
        }
     
        [TestMethod]
        public void ce103_strcmp_cs_imported_test_2()
        {
            Class2 strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported("Rabia", "Süme"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_2()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Rabia", "Süme"), 0, Strcmp.ce103_strcmp_cs_imported("Rabia", "Süme"));
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_imported_test_3()
        {
            Class2 strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_imported("Bad", "Laptop"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_3()
        {
            Class1 strcmp = new Class1();
            Class2 Strcmp = new Class2();
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs("Bad", "Laptop"), 0, Strcmp.ce103_strcmp_cs_imported("Bad", "Laptop"));
        }

        [TestMethod]
        public void ce103_strcpy_cs_imported_test_1()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("File", "Hardware"), "Hardware");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_1()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("File", "Hardware"), "Hardware", Strcpy.ce103_strcpy_cs_imported("File", "Hardware"), "Hardware");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_2()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("Fundemental", "Information"), "Information");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_2()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Fundemental", "Information"), "Information", Strcpy.ce103_strcpy_cs_imported("Fundemental", "Information"), "Information");
        }
     
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_3()
        {
            Class2 strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_imported("View", "Class"), "Class");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_3()
        {
            Class1 strcpy = new Class1();
            Class2 Strcpy = new Class2();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("View", "Class"), "Class", Strcpy.ce103_strcpy_cs_imported("View", "Class"), "Class");
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test1()
        {
            Class1 bin2hex = new Class1();
            byte[] bin = { 0x24, 0x29, 0xEA, 0x92, 0x42, 0x53 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '2', '4', '2', '9', 'E', 'A', '9', '2', '4', '2', '5', '3' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test1()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0xAD, 0xAD, 0xAD, 0xAD, 0xAD, 0xAD, 0xAD, 0xAD };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'D', 'A', 'D', 'A', 'D', 'A', 'D', 'A', 'D', 'A', 'D', 'A', 'D', 'A', 'D' };

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
            byte[] bin = { 0x24, 0x29, 0x24, 0x29, 0x24 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '2', '4', '2', '9', '2', '4', '2', '9', '2', '4' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test2()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0x29, 0x06, 0x01, 0x24, 0x29 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '2', '9', '0', '6', '0', '1', '2', '4', '2', '9' };

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
            byte[] bin = { 0xBD, 0xBD, 0xBD, 0xBD, 0xBD, 0xBD, 0xBD, 0xBD };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'B', 'D', 'B', 'D', 'B', 'D', 'B', 'D', 'B', 'D', 'B', 'D', 'B', 'D', 'B', 'D' };

            bin2hex.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test3()
        {
            Class2 imported = new Class2();
            byte[] bin = { 0xAE, 0xED, 0xEF, 0xEB, 0xEC, 0xEE };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'E', 'E', 'D', 'E', 'F', 'E', 'B', 'E', 'C', 'E', 'E' };

            imported.ce103_bin2hex_cs_imported(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test3()
        {
            Class1 bin2hex = new Class1();
            Class2 imported = new Class2();
            byte[] bin = { 0xCB, 0xDB, 0xAD, 0xAF, 0xEF, 0xEB, 0xEA, 0xAA, 0xFD };
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
            string hexstring = "2929292929292929";
            byte[] expectedArr = { 0x29, 0x29, 0x29, 0x29, 0x29, 0x29, 0x29, 0x29 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test1()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "ACABADAFAABA";
            byte[] expectedArr = { 0xAC, 0xAB, 0xAD, 0xAF, 0xAA, 0xBA };
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
            string hexstring = "AAAAADDDDD";

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
            string hexstring = "2429242924292429";
            byte[] expectedArr = { 0x24, 0x29, 0x24, 0x29, 0x24, 0x29, 0x24, 0x29 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test2()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "3571894563214569874143";
            byte[] expectedArr = { 0x35, 0x71, 0x89, 0x45, 0x63, 0x21, 0x45, 0x69, 0x87, 0x41, 0x43 };
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
            string hexstring = "EEBACADA";
            byte[] expectedArr = { 0xEE, 0xBA, 0xCA, 0xDA };

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
            string hexstring = "ADBCADBCADBCADBC";
            byte[] expectedArr = { 0xAD, 0xBC, 0xAD, 0xBC, 0xAD, 0xBC, 0xAD, 0xBC };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test3()
        {
            Class2 hex2bin = new Class2();
            string hexstring = "4292429242924292429242";
            byte[] expectedArr = { 0x42, 0x92, 0x42, 0x92, 0x42, 0x92, 0x42, 0x92, 0x42, 0x92, 0x42 };
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
            string hexstring = "EADFCBEADFCBEADFCB";
            byte[] expectedArr = { 0xEA, 0xDF, 0xCB, 0xEA, 0xDF, 0xCB, 0xEA, 0xDF, 0xCB};

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_imported(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            // assert by sequence
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }
    }
}
