# Racing-Passion2
C# and Python OBD2 university project
GUI for car diagnostic and telemetry

1) Описание: 

    Софтуер за диагностика на коли след 2000 година или коли с OBD 2 стандарт.
    Системата позволява на потребителите да направят диагностика или да следят данни на живо за техният автомобил.

2) Реализация на проекта:

   За реализацияра на проекта са използвани C# и Python, а базата данни е SQLite.

3) Ръководство на потребителя:

    След стартиране на приложението е нужна рагистрация, след това потребителят може да се логне в него.
    Следва Home screen където могат да се открият различните функции на приложението а това са:
    
    - Dashboard: данни на живо за автомобила(Обороти, скорост, температура на двигател, волтаж, статус на гориво и статус на въздух).
    - Car diagnostic: Търси грешки по мотора на автомобила.
    - Profile: Профил на потребителя.


    Нужна е OBD 2 (On-board diagnostics) ELM 327 блутут букса (https://www.amazon.com/obdator-Bluetooth-Scanner-Automotive-Diagnostic/dp/B074DWH8JR/ref=sr_1_6?dchild=1&keywords=ELM327&qid=1622373628&sr=8-6).
    
    Буксата се свързва към колата, след което приложението сканира за налични блутут устройства. След като открие OBD 2 буксата се свързва автоматично.
    

