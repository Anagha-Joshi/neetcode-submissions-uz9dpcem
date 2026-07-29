public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers = new HashSet<int>(nums);
        int longest = 0;
        foreach (int num in numbers){
            if(!numbers.Contains(num - 1)){
                int i = 0;
                while(numbers.Contains(num + i))
                    i++;
                longest = Math.Max(longest, i); 
            }
        }
        return longest;   
    }
}
