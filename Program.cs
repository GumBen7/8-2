namespace EightTwo {
    class Program {
        static void Main(string[] args) {
             var n = int.Parse(System.Console.ReadLine());
             var sArr = System.Console.ReadLine().Split();
             int[] a = new int[n];
             for (var i = 0; i < n; ++i) {
                a[i] = int.Parse(sArr[i]);
             }
             Heapsort(a);
             foreach (var i in a) {
                System.Console.Write(i + " ");
             }
        }

        static void Heapsort(int[] a) {
            var n = a.Length;
            for (var i = n/2 - 1; i >= 0; --i) Heapify(a, n, i);
            for (var i = n - 1; i >= 1; --i) {
                (a[0], a[i]) = (a[i], a[0]);
                Heapify(a, i, 0);
            } 
        }

        static void Heapify(int[] a, int n) {
            for (var i = n - 1; i >= 0; --i) {

            }
        }

        static void Sift(int[] a, int i, int n) {
            
        }

        static void Heapify(int[] a, int n, int i) {
            var largest = i;
            var left = i * 2 + 1;
            var right = i * 2 + 2;
            if (left < n && a[left] > a[largest]) largest = left;
            if (right < n && a[right] > a[largest]) largest = right;
            if (largest != i) {
                (a[largest], a[i]) = (a[i], a[largest]);
                Heapify(a, n, largest);
            }
        }
    }
}