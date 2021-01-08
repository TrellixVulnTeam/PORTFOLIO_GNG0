def save_ranking(*args, **kwargs):
    print(args)
    print(kwargs)
save_ranking('ming', 'alice', 'tom', fourth='wilson', fifth='roy')

def a(aa,bb,cc):
    print("aa = ", aa)
    print("bb = ", bb)
    print("cc = ", cc)

a('a값','b값','c값')
a(aa='aa값',cc='cc값',bb='bb값')

def aa(*aa):# 튜플로 사용할때
    print(aa)
def bb(**bb):
    print(bb)
aa(1,2,3,4,5,6,7)
bb(a=2,b=4,c=6,d=8)

def doa():
    '''this is doa function'''
    return 'a'

print(doa)
print(doa())
print(doa.__doc__)
print(doa.__name__)

def knights(saying):
    def inner(quote):
        return "We are the knights who say: '%s'" %quote
    return inner(saying)

print(knights('Ni'))

def my_range(first = 0,last = 10,step = 1):
    number = first
    while(number < last):
        yield number
        number += step

# yield 메모리에 생성, 한번 참조하면 사라진다
ranger = my_range(1,5)
# 출력 안되는것을 확인 할 수 있다.
for x in ranger:
    print(x)
print("한번더")
for x in ranger:
    print(x)