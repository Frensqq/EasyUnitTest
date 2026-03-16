# TestSession2

## Описание
Проект содержит логику для расчета заработной платы сотрудников на основе должности и количества ставок, а также набор модульных тестов для проверки этой логики.

## Класс Calculation

### Метод SalaryCalculation(string post, double bet)
Выполняет расчет заработной платы сотрудника.

**Алгоритм работы:**
- Приведение должности к нижнему регистру
- Определение базовой ставки:
  - Директор — 30000
  - Мастер — 20000
  - Водитель — 15000
  - *Неизвестная должность — возврат -1*
- Валидация ставки (0-3), иначе возврат -1
- Расчет зарплаты "на руки" (с вычетом 13%): `salary = (базовая_ставка * bet) * 0.87`

**Возвращает:** рассчитанную зарплату или -1 при ошибке

## Тестирование

Набор автоматизированных тестов (NUnit) в классе `Tests`.

### Низкая сложность (позитивные сценарии)

| Тест | Должность | Ставка | Ожидаемый результат |
|------|-----------|--------|---------------------|
| Test_salary_postDirector_bet08_return20880 | Директор | 0.8 | 20880 |
| Test_salary_postMaster_bet05_return8700 | Мастер | 0.5 | 8700 |
| Test_salary_postDriver_bet1_return13050 | Водитель | 1 | 13050 |
| Test_salary_postDirector_bet2_return52000 | Директор | 2 | 52200 |
| Test_salary_postMaster_bet01_return1740 | Мастер | 0.1 | 1740 |
| Test_salary_postDriver_bet15_return19575 | Водитель | 1.5 | 19575 |
| Test_salary_postDriver_bet04_return5220 | Водитель | 0.4 | 5220 |
| Test_salary_postDirector_bet025_return6525 | Директор | 0.25 | 6525 |
| Test_salary_postDirector_bet12_return31320 | Директор | 1.2 | 31320 |
| Test_salary_postMaster_bet17_return29580 | Мастер | 1.7 | 29580 |

### Высокая сложность (негативные и граничные сценарии)

| Тест | Должность | Ставка | Ожидаемый результат |
|------|-----------|--------|---------------------|
| HardTest_salary_postDriver_betNegative04_returnNegative1 | Водитель | -0.4 | -1 |
| HardTest_salary_postNull_bet08_returnNegative1 | (пусто) | 0.8 | -1 |
| HardTest_salary_postMaster_bet135_returnNegative1 | Мастер | 13.5 | -1 |
| HardTest_salary_postDIRECRTOR_bet1_return26100 | ДИРЕКТОР | 1 | 26100 |
| HardTest_salary_postmAsTer_bet1_return17400 | мАсТер | 1 | 17400 |