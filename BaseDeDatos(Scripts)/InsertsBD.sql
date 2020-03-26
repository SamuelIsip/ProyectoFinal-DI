/*RA - Creaci�n y modificaci�n de tablas con Oracle y tratamiento de datos.*/
/*CEV - Se han creado y modificado tablas*/

/*---------------------RESULTADOS DE APRENDIZAJE------------------*/ 
/*RA*/
INSERT INTO RA(nombre,nota) VALUES('Manejo diagramas entidad-relaci�n y gesti�n de DDBB con Access', 2.5);
INSERT INTO RA(nombre,nota) VALUES('Creaci�n y modificaci�n de tablas con Oracle y tratamiento de datos', 3.5);
INSERT INTO RA(nombre,nota) VALUES('Programaci�n de bases de datos usando PLSQL', 4);
/*----------------------------------------------------------------*/


/*---------------------CRITERIOS DE EVALUACION--------------------*/
/*RA1 - Manejo diagramas entidad-relaci�n y gesti�n de DDBB con Access*/
/*CEV*/
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(1,'Se han usado bases de datos relacionales', 1);
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(1,'Se ha desarrollado una DDBB en Access', 1.5);

/*RA2 - Creaci�n y modificaci�n de tablas con Oracle y tratamiento de datos*/
/*CEV*/
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(2,'Se han creado y modificado tablas', 1.5);
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(2,'Se han tratado datos de las tablas', 2);

/*RA3 - Programaci�n de bases de datos usando PLSQL*/
/*CEV*/
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(3,'Se han creado procedimientos y funciones', 2);
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(3,'Se han creado triggers para automatizar tareas', 2);
/*----------------------------------------------------------------*/


/*-----------------------------PREGUNTAS--------------------------*/
/*RA1 - Manejo diagramas entidad-relaci�n y gesti�n de DDBB con Access*/
/*CEV1 - Se han usado bases de datos relacionales*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'CORTA','Nombra las caracter�sticas ideales de las DDBB','Versatilidad para representar la informaci�n, desempe�o, minima redundancia, capacidad de acceso, integridad, simplicidad, seguridad, privacidad,afinacion, interfaz con el pasado y futuro, independencia del sistema logico y fisico','Para tener la puntuacion total deben estar todas');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'CORTA','Nombra las visiones de una base de datos','Vision externa, conceptual, fisica','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'TEST','Como se implementa una relacion muchos a muchos entre dos trablas: A) no se puede  B) usando la tabla con menos filas  C)con una tabla auxiliar','C) con una tabla auxiliar','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'TEST','Cual de estas no puede ser null: A)Clave principal  B)Clave foranea  C)Ninguna puede ser null','A)Clave principal','Pregunta tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'DESARROLLO','Define clave primaria, foranea y candidata.','Clave primaria o principal: de entre todas las candidatas se elegir� una como principal, Clave for�nea: ser� un atributo o conjunto de atributos que son clave primaria de otra tabla con la que est� relacionada, Claves candidatas: los atributos o conjuntos de atributos que cumplen la condici�n de ser clave.','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'DESARROLLO','Explica qu� es una base de datos distribuida','En una base de datos distribuida tenemos una serie de bases de datos que pueden estar distribuidas geogr�ficamente por todo el mundo. Por lo tanto, una base de datos distribuida es una colecci�n de m�ltiples bases de datos interconectadas, que pueden estar extendidas f�sicamente a trav�s de varios lugares comunicados mediante una red inform�tica.','Pregunta de desarrollo');

/*RA1 - Manejo diagramas entidad-relaci�n y gesti�n de DDBB con Acces*/
/*CEV2 - Se ha desarrollado una DDBB en Access*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'CORTA','�Qu� hace la m�scara de entrada ">" en Access?','Convierte todos los caracteres que le siguen a may�scula','Pregunta corta');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'CORTA','�Qu� hace la m�scara de entrada "0" en Access?','El usuario debe escribir un d�gito (0 a 9)','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'TEST','�Con cu�l de las siguientes m�scaras de entrada el usuario puede escribir una letra?: A)L B)? C)A ','B)L','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'TEST','De las siguientes m�scaras de entrada con cu�l el usuario puede escribir caracteres o espacios: A)C B)A C)B','A)C','Pregunta de tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'DESARROLLO','�Qu� es un criterio en ACCESS','Un criterio es similar a una f�rmula, es una cadena que puede estar compuesta por referencias de campo, operadores y constantes. Los criterios de b�squeda tambi�n se conocen como expresiones en Access','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'DESARROLLO','�Qu� son los campos de b�squeda?','Campos de b�squeda    Hay dos tipos de campos de b�squeda: aquellos que buscan valores en un origen de datos existente (usando una clave externa), y aquellos que se basan en una lista de valores especificados cuando se crea el campo de b�squeda.
Los campos de b�squeda que se basan en una lista de valores especificados son del tipo de datos Texto y los criterios v�lidos son los mismos que en otros campos de texto.','Pregunta de desarrollo');

/*RA2 - Creaci�n y modificaci�n de tablas con Oracle y tratamiento de datos*/
/*CEV3 - Se han creado y modificado tablas*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'CORTA','Nombra los distintos tipos de restricciones sobre una tabla que permite CREATE TABLE','Claves primarias, Claves ajenas, Obligatoriedad, Valores por defecto, Verificaci�n de condiciones','Pregunta corta');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'CORTA','�Cu�ntas claves ajenas se pueden definir en una tabla?','Tantas claves ajenas como sean precisas','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'TEST','�Con cu�l de las siguientes instrucciones se borra una columna con de la tabla usando ALTER TABLE?: A)ADD B)MODIFY C)Ninguna de las anteriores','C)Ninguna de las anteriores','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'TEST','Selecciona las instrucciones correctas para crear, borrar y modificar tablas: A)CREATE DROP ALTER B)CREATE DELETE ALTER C)Ninguna de las anteriores','A)CREATE DROP ALTER','Pregunta tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'DESARROLLO','Dime todo lo que sepas sobre la restricci�n PRIMARY KEY','La clave primaria es una columna o un conjunto de columnas que
identifican un�vocamente a cada fila, debe ser �nica, no nula y obligatoria, como m�ximo podemos definir una clave primaria por tabla, se puede referenciar por una columna o columnas de otra tabla, a
la que llamaremos clave ajena, cuando se crea una clave primaria, autom�ticamente se crea un
�ndice que facilita el acceso a la tabla, para definir una clave primaria usamos la restricci�n PRIMARY KEY','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'DESARROLLO','�Para qu� usamos ON DELETE CASCADE con la restricci�n FOREIGN KEY?','La cl�usula
ON DELETE CASCADE o borrado en cascada,se define cuando al borrar las filas asociadas con claves primarias deseamos que se eliminen autom�ticamente
las filas con claves ajenas que referencien a dichas claves','Pregunta de desarrollo');



/*RA2 - Creaci�n y modificaci�n de tablas con Oracle y tratamiento de datos*/
/*CEV4 - Se han tratado datos de las tablas*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'CORTA','�Qu� es un registro? ','Un registro es una fila de la tabla que contiene los datos propiamente dichos','Pregunta corta');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'CORTA','�Qu� se debe tener en cuenta a la hora de ingresar los datos de cada registro?','Debe tenerse en cuenta la cantidad y el orden de los campos','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'TEST','�Con qu� sentencia se a�aden datos a una tabla?: A)INSERT B)UPDATE C)MODIFY','A)INSERT','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'TEST','�Cu�ntos registros de la tabla se recuperan con SELECT * : A)Ninguno B)Un registro C)Todos','C)Todos','Pregunta tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'DESARROLLO','�Qu� es la integridad referencial de una Base de Datos?','La integridad referencial asegura que se mantengan las referencias entre las claves primarias y las externas. Por ejemplo, controla que si se agrega un c�digo de editorial en la tabla libros, tal c�digo exista en la tabla editoriales','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'DESARROLLO','�Qu� es una subconsulta dentro de una Base de Datos?','Una subconsulta es una consulta anidada en una instrucci�n SELECT, INSERT, UPDATE o DELETE, o bien en otra subconsulta. Las subconsultas se pueden utilizar en cualquier parte en la que se permita una expresi�n','Pregunta de desarrollo');


/*RA3 - Programaci�n de bases de datos usando PLSQL*/
/*CEV5 - Se han creado procedimientos y funciones*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'CORTA','�Qu� tipos de programas se pueden construir con PL/SQL?','Procedimientos, funciones y bloques an�nimos, paquetes, etc','Pregunta corta');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'CORTA','�Qu� cl�usulas son obligatorias en un bloque?','Las �nicas cl�usulas obligatorias son BEGIN y END','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'TEST','�Qui�n requiere m�s c�digo? A)Funci�n B)Procedimiento C)Iguales','A)Funci�n','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'TEST','�Qu� tipo de programa obliga a retornar un valor? A)PROCEDURE B)FUNCTION C)PACKAGE','B)FUNCTION','Pregunta tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'DESARROLLO','Indica donde se almacenan los programas PL/SQL y una de sus utilidades','Los programas creados con PL/SQL los podemos almacenar en nuestra base de datos como cualquier otro objeto quedando disponibles para los usuarios. El uso del lenguaje PL/SQL es imprescindible para construir disparadores de bases de datos (triggers)','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'DESARROLLO','�Qu� es un Disparador o Trigger?','Los disparadores (o triggers) son bloques de c�digo PL/SQL asociados a una tabla y que se ejecutan autom�ticamente como reacci�n a una operaci�n DML espec�fica (INSERT, UPDATE o DELETE) sobre dicha tabla','Pregunta de desarrollo');



/*RA3 - Programaci�n de bases de datos usando PLSQL*/
/*CEV6 - Se han creado triggers para automatizar tareas*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'CORTA','�Cu�ndo se ejecuta un trigger?','Cuando se intenta modificar una tabla o vista asociada a �l','Pregunta corta');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'CORTA','�Cu�l es el cometido principal de los triggers?','Conservar la integridad referencial entre tablas y registrar cambios o actuar cuando estos ocurren','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'TEST','�Cu�les es una palabra reservada al momento en el que un trigger se activa? A)INSTEAD IN B)BELONG C)AFTER','C)AFTER','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'TEST','�Cu�ndo un trigger act�a a nivel de sentencia? A)Nunca B)Con STATEMENT C)Con FOR EACH ROW','B)Con STATEMENT','Pregunta tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'DESARROLLO','�En qu� se diferencian los procedimentos y los triggers?','En que no se pueden invocar directamente(se activan cuando se intenta modificar la tabla asociada a ellos), no reciben ni devuelven par�metros y sirven para mantener la integridad de los datos y no para obtener resultados de consultas','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'DESARROLLO','�C�mo funciona un trigger?','El trigger se activa cuando la tabla asociada va a ser modificada, y lo hace en el momento(BEFORE o AFTER) y para el tipo de modificaci�n realizada(INSERT, UPDATE o DELETE) y ejecuta el c�digo que tiene en BEGIN','Pregunta de desarrollo');


/*--------------------------------------------------------------*/

commit;