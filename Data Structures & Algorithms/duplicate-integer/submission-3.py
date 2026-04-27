class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        check = defaultdict(int);
    
        for i in nums:
            if i in check:
                return True
            check[i] += 1

        return False