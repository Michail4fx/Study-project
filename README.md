# Учебный проект шифрование/расшифрование текста с помощью шифра Виженера

[Название](#Название)

[Описание](#Описание)

[Особенности](#Особенности)

[Техническое описание](#Техническое-описание)

## Название

### Наименование
Encryption 

### Версия
1.3

### Дополнительное описание и примечание к предыдущим версиям
Приставка “Anime Edition” используется в шуточных целях и обязывает использовать иконку в стиле аниме. Иное изображение – недопустимо!
В версии 1.2 использовалась кнопка для смены заднего фона на картинку с аниме девочкой, удалена по причине того, что преподаватель - не оценил данное решение.

## Описание
Данный учебный проект создавался в качестве решения задачи по предмету "Информационная безопасность". Во время разработки список требований пополнялся.

### Технические условия:
##### 1) Зашифрование и расшифрование текстов, записанных кириллицей;
##### 2) Замена во вводимом тексте и ключе буквы Ё на Е;
##### 3) Очистка вводимого текста от всех небуквенных символов, знаков препинания, пробелов и приведение всех букв к строчному регистру;
##### 4) Выдача обработанного текста группами по пять символов;
##### 5) Защита от неправильных действий пользователя;
##### 6) Дружественный интерфейс.

### Технологии в проекте
Проект выполнен на языке C#, в API Windows Forms. В проекте реализован шифр Виженера. 

## Особенности 
Отличительной особенностью является прорабатывание интерфейса на "дуракоутойчивость", то есть на предотвращение недопустимых действий со стороны пользователя:

##### Первое поле "Введите ключ:" - можно ввести только строчные/прописные буквы русского алфавита, кроме буквы "ё", во время выполнения операции прописные символы переводятся в строчные. Нельзя вставить текст правой кнопкой мыши или операцией "CTRL+V";

##### Второе поле "Введите текст:" - можно вести цифры и строчные/прописные буквы русского алфавита, кроме буквы "ё", во время выполнения операции символы переводятся в строчные, цифры и пробелы удаляются. Можно вставить запрещенные символы с помощью правой кнопкой мыши или операцией "CTRL+V", однако в последствии данные символы не используются при выполнении операции;

##### Третье поле - нельзя взаимодействовать пользователю, можно только скопировать текст с помощью правой кнопкой мыши или операцией "CTRL+C".

##### Примечание: При загрузке стороннего текста, происходит удаление запрещенных символов.

## Техническое описание

### Установка и настройка

Для запуска требуется только файл "Encryption (1.3) Anime Edition.exe", не требуется установка или предварительная настройка. 

### Основное взаимодействие с программой

##### Первое поле "Введите ключ:" - обязательное для заполнения поле, при отсутствии символов или когда символов меньше 2 - выскакивает предупреждение, необходимо для прописывания ключа зашифровывания или расшифрования;

##### Второе поле "Введите текст:» - обязательное для заполнения поле, предназначена для работы с зашифрованным текстом или текстом, который необходимо расшифровать;

##### Опция "Зашифровать" - обязательно для выбора его или "Расшифровать", выбран по умолчанию, выполняет зашифровывания текста, по методу Вижинера, из второго текстового поля - результат записывается в третье текстовое поле;

##### Опция "Расшифровать" - обязательно для выбора его или "Зашифровать", выполняет расшифровывание текста, по методу Вижинера, из второго текстового поля - результат записывается в третье текстовое поле;

##### Кнопка "Выполнить" - запускает работу выбранных опций.

### Вспомогательное взаимодействие с программой

#### Раздел "Файл":

Примечание: По умолчанию данные кнопки открывают корневую папку "C:\" и работает только с текстовыми форматами данных. 

##### "Открыть файл" - открывает текстовый файл и переносить текстовую информацию во вторую ячейку;

##### "Сохранить файл" - происходит запись текста из третей ячейки текста в формате "txt".

#### Раздел "Вспомогательные функции":

##### "Переставить текст" - переносит текст из третьей ячейки, с итоговым результатом, во вторую ячейку;

##### "Форматировать текст" - удаление пробелов в третьей ячейке, с итоговым результатом, предназначена для удобства чтения;

##### "Очистить" - удаление текста в первой и второй ячейке текста.
