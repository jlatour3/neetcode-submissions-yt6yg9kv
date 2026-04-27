class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        # turns into arr
        s=list(s)
        t=list(t)
        
        # sort on arr
        s.sort()
        t.sort()

        if s==t:
            return True
        else:
            return False