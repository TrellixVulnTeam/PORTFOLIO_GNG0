# 8.6 이차원 딕셔너리 life를 만들어 보자
# 최상위 키는 'animals','plants','other'다
# 그리고'animals;는 각각 'cat','octopi','emus'를 키로
# 하고, 'Henri','Grunmy','Lucy'를 값으로 하는
# 또 다른 딕셔너리를 참조하고 있다
# 나머지 요소는 빈 딕셔너리를 참조한다
life = {}
life['animals'] = {'cat':'Henry', 'octopi':'Grunmy', 'emus':'Lucy'}
life['plants'] = {}
life['others'] = {}
print(life)
# 8.7 life 딕셔너리의 최상위 키를 출력해보자
keys = life.keys()
print(keys)
# 8.8 life['animals']의 모든 키를 출력해보자
keys_animals = life['animals'].keys()
print(keys_animals)
# 8.9 life['animals']['cats']의 모든 값을 출력해보자
value_cat = life['animals']['cat']
print(value_cat)
# 8.10 딕셔너리 컴프리헨션 으로 squares 딕셔너리를 생성한다
# range(10)를 키로 하고 각 키의 제곱을 값으로 한다

# life['square'] = {}
# for i in range(10):
#      life['square'][i] = i*i
life['square'] = {k : k * k for k in range(10)}
print(life['square'])
# 8.11 셋 컴프리헨션을 이용하여 range(10)에서 홀수 셋을 만든다
odd = {odd:odd*odd for odd in range(10) if odd%2 == 1}
print(odd)


