class Sol:
    def restoreIpAdd(self, s):
        result = []
        self.restoreIpAddRecur(result, s, 0, "", 0)
        return result
        
    def restoreIpAddRecur(self, result, s, start, current, dots):
        # DFS searching
        if (4 - dots) * 3 < len(s) - start or (4 - dots) > len(s) - start:
            return
        
        if start == len(s) and dots == 4:
            result.append(current[:-1])
        else:
            for i in xrange(start, start + 3):
                if len(s) > i and self.isValid(s[start:i + 1]):
                    current += s[start:i + 1] + '.'
                    self.restoreIpAddRecur(result, s, i + 1, current, dots + 1)
                    current = current[:-(i - start + 2)]
        
    def isValid(self, s):
        if len(s) == 0 or (s[0] == '0' and s != "0"):
            return False
        return int(s) < 256
    
print Sol().restoreIpAdd("25525511135")