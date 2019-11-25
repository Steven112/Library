# Library

![image](https://user-images.githubusercontent.com/54567861/69506171-c99c3e80-0f03-11ea-9859-5eef17ab9459.png)

Este es un programa desarrollado con la finalidad de gestionar el área de préstamo de libros en una biblioteca. Este programa contiene ciertas cualidades que a parte de llevar el registro de los libros prestados, también se le atribuye que puede llevar un inventario de los libros que se encuentran disponibles. Ahora le dare una pequeña explicación de lo que hace cada registro del programa.

# Login

 ![image](https://user-images.githubusercontent.com/54567861/69506669-0406db00-0f06-11ea-8752-45c1fb9852aa.png)

Este formulario no hace mas que permitirte entrar a lo que es el menú principal del programa, para ello necesitas tener un usuario ya agregado en la base de datos, por defecto el programa vine con un usuario administrador agregado en el combobox, pero para poder entrar necesitas saber la contraseña la cual se encuentra en la base de datos pero esta encriptada.

# Menú  Principal
 
 ![image](https://user-images.githubusercontent.com/54567861/69506707-2862b780-0f06-11ea-8f52-969e003d20b2.png)

Este es la primera ventana en aparecer luego de pasar el login, el Menú Principal con el logo insignia del proyecto, como podemos observar en ella se encuentran tres opciones(Registros, Consultas y ayuda); en la primera opción  podemos acceder a los distintos registros que existen en el programa, de los cuales hablaremos mas adelante; la segunda opción del menú abre paso a lo que son las diferentes consultas del programa, las cuales tienes distintas formas de búsqueda, esto dependerá del registro al cual corresponde la consulta; en la tercera opción abre lo que es una ventana de ayuda que contiene el link de este archivo

# Registro Prestamos
 
![image](https://user-images.githubusercontent.com/54567861/69506748-5647fc00-0f06-11ea-98fc-de41bd7597c5.png)

Este es el registro mas importante del proyecto ya que en el se registran los prestamos con el nombre del estudiante, el titulo del libro, la fecha en que se presta el libro y la fecha de devolución del libro, al guardar el préstamo inmediatamente el libro deja de estar disponible en la base de datos.

# Registro de Libros

 ![image](https://user-images.githubusercontent.com/54567861/69506778-72e43400-0f06-11ea-8d91-95dd272832da.png)


Este es uno de los registros mas importantes ya que en él se pueden actualizar la lista de libros de la base de datos, permitiendo agregar, eliminar o incluso modificar los datos de un libro.

# Registros Categorías y Editoriales
 
 ![image](https://user-images.githubusercontent.com/54567861/69506783-7c6d9c00-0f06-11ea-8733-f9e3600bb989.png)


En el primer registro se agregan las diferentes categorías de cada libro, ejemplo: Un libro que sea de la categoría de acción:.
En el segundo registro se agregan las editoriales de las cuales es proveniente cada ejemplar de la biblioteca.
Cabe destacar que para poner agregar un nuevo libro o incluso modificar uno existente, es necesario la existencia de por lo menos una editorial y una categoría.

# Registro Estudiantes
 
![image](https://user-images.githubusercontent.com/54567861/69506840-bdfe4700-0f06-11ea-9a08-ae93b63b08c0.png)

En este registro no se hace mas que agregar un nuevo estudiante con todos sus datos personales y al final podemos observar el usuario que añadió o modifico a ese nuevo estudiante a la base de datos, para realizar un préstamo es necesario que el estudiante al que se va a prestar un ejemplar este agregado en la base de datos del sistema.

# Registro Usuarios

![image](https://user-images.githubusercontent.com/54567861/69506850-cb1b3600-0f06-11ea-98b7-edd5e6a4a6f0.png)

En este Registro se agregan los usuarios con los cuales podemos iniciar sesión en el programa y agregar un nuevo estudiante, el registro añade todos los datos de ese usuario a la base de datos del sistema.

# Registro Devoluciones

![image](https://user-images.githubusercontent.com/54567861/69506886-f0a83f80-0f06-11ea-8b39-dd393bf5b4c8.png)

En el registro devolución se agregan las devoluciones de cada libro, buscando antes el préstamo realizado, seccionando el estudiante al que se le presto y el libro prestado, al buscar el préstamo se agrega automáticamente la fecha de devolución establecida y el usuario que registra la devolución puede establecer la fecha de devolución del libro, permitiendo esto ver los libros que tuvieron retraso de devolución y los que no, al guardar la devolución inmediatamente el libro vuelve a estar disponible en la base de datos para nuevamente poder ser prestado.

# Derechos de Autor

![image](https://user-images.githubusercontent.com/54567861/69507064-9eb3e980-0f07-11ea-96c9-9484f89930e7.png)

Este programa tine la firma de derecho de autro atribuida al estudiante de ingenieria Steven Natiel Caceres Nuñez, el cual tiene en su poder el codigo fuente original de este programa.







