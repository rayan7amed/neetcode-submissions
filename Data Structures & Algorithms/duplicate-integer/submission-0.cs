public class Solution {
    public bool hasDuplicate(int[] nums) {
        for(int i = 0; i < nums.Length - 1; ++i){
            int num = nums[i];
            for(int j = i + 1; j < nums.Length; ++j){
                if (nums[j] == nums[i])
                return true;
            }
        }
        return false;
    }
}