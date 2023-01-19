def count_nines(n):
    if(n<9):
        return 0   
    s = str(n)
    l = len(s)
    count = 0
    for i in range(0, l):
        count += int(int(s[i]) * (l-i-1) * 10**(l-i-2))
        if(s[i] == '9'):
            if(l-i>1):                     
                count += (int(s[i+1:l]) + 1)
            else:
                count += 1
    return count

print(count_nines(9999))
# 
# a = ""
# for i in range(1, 1001):
#     a += (str(i)+";"+str(count_nines(i))+"\n")
# print(a)
# # write to csv file
# with open('testpy.csv', 'w') as f:
#     f.write(a)  





