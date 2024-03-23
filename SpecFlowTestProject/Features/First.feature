Feature: Начальный тест для изучения

Scenario: Простой тест без тела

Scenario: Простой тест с Given
	Given Открыт браузер

Scenario: Простой тест c Given и When
	Given Открыт браузер
	When страница логина открыта

Scenario: Простой тест с 2  Given
	Given Открыт браузер
	Given страница логина открыта
	Then username is filled

Scenario: Простой тест с Given и When и Then
	Given Открыт браузер
	When страница логина открыта
	Then username is filled
