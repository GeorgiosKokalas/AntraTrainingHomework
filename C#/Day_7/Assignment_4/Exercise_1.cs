namespace Day2
{
    public class MyStack<T>
    {
        private int count;
        private T[] stack;

        public MyStack() {
            count = 0;
            stack = null;
        }
        
        public int Count() { return count; }

        public T Pop() {
            T return_val = stack[--count]; // Count should decrement before anything else happens
            T[] temp_stack = new T[count];
            for (int i = 0; i < count; i++) { temp_stack[i] = stack[i]; }
            stack = temp_stack;
            return return_val;
        }

        public void Push(T new_val) {
            if (stack == null) {
                stack = new T[1] { new_val };
                count = 1;
            } else {
                T[] temp_stack = new T[++count]; // Count should increment before anything else happens
                for (int i = 0; i < count-1; i++) { temp_stack[i] = stack[i]; }
                temp_stack[count - 1] = new_val;
                stack = temp_stack;
            }
        }
    }
}
