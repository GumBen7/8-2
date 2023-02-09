namespace EightTwo {
    class Program {
        static void Main(string[] args) {
             var n = int.Parse(Console.ReadLine());
             var sArr = Console.ReadLine().Split();
             int[] a = new int[n];
             for (var i = 0; i < n; ++i) {
                a[i] = int.Parse(sArr[i]);
             }
             Heapsort(a);
        }

        static void Heapsort(int[] a) {
            var len = a.Length;
            for(var i = 0; i < len; ++i) {
                a[i] = 0;
            }
        }
    }
}