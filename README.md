Полный проект и его описание можно скачать с ulearn.me (Основы программирования на примере C#. Часть 2)

В этой задаче вам нужно реализовать стек ограниченного размера. Этот стек работает как обычный стек, однако при превышении максимального размера удаляет самый глубокий элемент в стеке. Таким образом в стеке всегда будет ограниченное число элементов.

Реализуйте класс LimitedSizeStack. Отладьте его реализацию с помощью тестов в классе LimitedSizeStack_should. Проверьте эффективность операции Push с помощью теста из класса LimitedSizeStack_PerformanceTest.

Изучите класс ListModel — в нём реализована логика работы кнопок в приложении.

Реализуйте методы Undo и CanUndo. Для этого нужно хранить историю последних limit действий удаления/добавления. Используйте для этого класс LimitedSizeStack из прошлой задачи. Его не нужно включать в отправляемый на проверку файл, считайте, что этот класс уже есть в проекте.

Метод Undo отменяет последнее действие из истории. Метод CanUndo возвращает true, если на данный момент история действий не пуста, то есть если вызов Undo будет корректным. Иначе метод должен вернуть false. Проверить корректность своего решения можно на модульных тестах из класса ListModel_Should и ListModel_PerformanceTest.
