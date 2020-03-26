/*RA - Creación y modificación de tablas con Oracle y tratamiento de datos.*/
/*CEV - Se han creado y modificado tablas*/

/*---------------------RESULTADOS DE APRENDIZAJE------------------*/ 
/*RA*/
INSERT INTO RA(nombre,nota) VALUES('Manejo diagramas entidad-relación y gestión de DDBB con Access', 2.5);
INSERT INTO RA(nombre,nota) VALUES('Creación y modificación de tablas con Oracle y tratamiento de datos', 3.5);
INSERT INTO RA(nombre,nota) VALUES('Programación de bases de datos usando PLSQL', 4);
/*----------------------------------------------------------------*/


/*---------------------CRITERIOS DE EVALUACION--------------------*/
/*RA1 - Manejo diagramas entidad-relación y gestión de DDBB con Access*/
/*CEV*/
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(1,'Se han usado bases de datos relacionales', 1);
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(1,'Se ha desarrollado una DDBB en Access', 1.5);

/*RA2 - Creación y modificación de tablas con Oracle y tratamiento de datos*/
/*CEV*/
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(2,'Se han creado y modificado tablas', 1.5);
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(2,'Se han tratado datos de las tablas', 2);

/*RA3 - Programación de bases de datos usando PLSQL*/
/*CEV*/
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(3,'Se han creado procedimientos y funciones', 2);
INSERT INTO CEV(cod_ra,nombre,nota) VALUES(3,'Se han creado triggers para automatizar tareas', 2);
/*----------------------------------------------------------------*/


/*-----------------------------PREGUNTAS--------------------------*/
/*RA1 - Manejo diagramas entidad-relación y gestión de DDBB con Access*/
/*CEV1 - Se han usado bases de datos relacionales*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'CORTA','Nombra las características ideales de las DDBB','Versatilidad para representar la información, desempeño, minima redundancia, capacidad de acceso, integridad, simplicidad, seguridad, privacidad,afinacion, interfaz con el pasado y futuro, independencia del sistema logico y fisico','Para tener la puntuacion total deben estar todas');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'CORTA','Nombra las visiones de una base de datos','Vision externa, conceptual, fisica','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'TEST','Como se implementa una relacion muchos a muchos entre dos trablas: A) no se puede  B) usando la tabla con menos filas  C)con una tabla auxiliar','C) con una tabla auxiliar','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'TEST','Cual de estas no puede ser null: A)Clave principal  B)Clave foranea  C)Ninguna puede ser null','A)Clave principal','Pregunta tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'DESARROLLO','Define clave primaria, foranea y candidata.','Clave primaria o principal: de entre todas las candidatas se elegirá una como principal, Clave foránea: será un atributo o conjunto de atributos que son clave primaria de otra tabla con la que está relacionada, Claves candidatas: los atributos o conjuntos de atributos que cumplen la condición de ser clave.','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (1,'DESARROLLO','Explica qué es una base de datos distribuida','En una base de datos distribuida tenemos una serie de bases de datos que pueden estar distribuidas geográficamente por todo el mundo. Por lo tanto, una base de datos distribuida es una colección de múltiples bases de datos interconectadas, que pueden estar extendidas físicamente a través de varios lugares comunicados mediante una red informática.','Pregunta de desarrollo');

/*RA1 - Manejo diagramas entidad-relación y gestión de DDBB con Acces*/
/*CEV2 - Se ha desarrollado una DDBB en Access*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'CORTA','¿Qué hace la máscara de entrada ">" en Access?','Convierte todos los caracteres que le siguen a mayúscula','Pregunta corta');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'CORTA','¿Qué hace la máscara de entrada "0" en Access?','El usuario debe escribir un dígito (0 a 9)','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'TEST','¿Con cuál de las siguientes máscaras de entrada el usuario puede escribir una letra?: A)L B)? C)A ','B)L','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'TEST','De las siguientes máscaras de entrada con cuál el usuario puede escribir caracteres o espacios: A)C B)A C)B','A)C','Pregunta de tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'DESARROLLO','¿Qué es un criterio en ACCESS','Un criterio es similar a una fórmula, es una cadena que puede estar compuesta por referencias de campo, operadores y constantes. Los criterios de búsqueda también se conocen como expresiones en Access','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (2,'DESARROLLO','¿Qué son los campos de búsqueda?','Campos de búsqueda    Hay dos tipos de campos de búsqueda: aquellos que buscan valores en un origen de datos existente (usando una clave externa), y aquellos que se basan en una lista de valores especificados cuando se crea el campo de búsqueda.
Los campos de búsqueda que se basan en una lista de valores especificados son del tipo de datos Texto y los criterios válidos son los mismos que en otros campos de texto.','Pregunta de desarrollo');

/*RA2 - Creación y modificación de tablas con Oracle y tratamiento de datos*/
/*CEV3 - Se han creado y modificado tablas*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'CORTA','Nombra los distintos tipos de restricciones sobre una tabla que permite CREATE TABLE','Claves primarias, Claves ajenas, Obligatoriedad, Valores por defecto, Verificación de condiciones','Pregunta corta');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'CORTA','¿Cuántas claves ajenas se pueden definir en una tabla?','Tantas claves ajenas como sean precisas','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'TEST','¿Con cuál de las siguientes instrucciones se borra una columna con de la tabla usando ALTER TABLE?: A)ADD B)MODIFY C)Ninguna de las anteriores','C)Ninguna de las anteriores','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'TEST','Selecciona las instrucciones correctas para crear, borrar y modificar tablas: A)CREATE DROP ALTER B)CREATE DELETE ALTER C)Ninguna de las anteriores','A)CREATE DROP ALTER','Pregunta tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'DESARROLLO','Dime todo lo que sepas sobre la restricción PRIMARY KEY','La clave primaria es una columna o un conjunto de columnas que
identifican unívocamente a cada fila, debe ser única, no nula y obligatoria, como máximo podemos definir una clave primaria por tabla, se puede referenciar por una columna o columnas de otra tabla, a
la que llamaremos clave ajena, cuando se crea una clave primaria, automáticamente se crea un
índice que facilita el acceso a la tabla, para definir una clave primaria usamos la restricción PRIMARY KEY','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (3,'DESARROLLO','¿Para qué usamos ON DELETE CASCADE con la restricción FOREIGN KEY?','La cláusula
ON DELETE CASCADE o borrado en cascada,se define cuando al borrar las filas asociadas con claves primarias deseamos que se eliminen automáticamente
las filas con claves ajenas que referencien a dichas claves','Pregunta de desarrollo');



/*RA2 - Creación y modificación de tablas con Oracle y tratamiento de datos*/
/*CEV4 - Se han tratado datos de las tablas*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'CORTA','¿Qué es un registro? ','Un registro es una fila de la tabla que contiene los datos propiamente dichos','Pregunta corta');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'CORTA','¿Qué se debe tener en cuenta a la hora de ingresar los datos de cada registro?','Debe tenerse en cuenta la cantidad y el orden de los campos','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'TEST','¿Con qué sentencia se añaden datos a una tabla?: A)INSERT B)UPDATE C)MODIFY','A)INSERT','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'TEST','¿Cuántos registros de la tabla se recuperan con SELECT * : A)Ninguno B)Un registro C)Todos','C)Todos','Pregunta tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'DESARROLLO','¿Qué es la integridad referencial de una Base de Datos?','La integridad referencial asegura que se mantengan las referencias entre las claves primarias y las externas. Por ejemplo, controla que si se agrega un código de editorial en la tabla libros, tal código exista en la tabla editoriales','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (4,'DESARROLLO','¿Qué es una subconsulta dentro de una Base de Datos?','Una subconsulta es una consulta anidada en una instrucción SELECT, INSERT, UPDATE o DELETE, o bien en otra subconsulta. Las subconsultas se pueden utilizar en cualquier parte en la que se permita una expresión','Pregunta de desarrollo');


/*RA3 - Programación de bases de datos usando PLSQL*/
/*CEV5 - Se han creado procedimientos y funciones*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'CORTA','¿Qué tipos de programas se pueden construir con PL/SQL?','Procedimientos, funciones y bloques anónimos, paquetes, etc','Pregunta corta');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'CORTA','¿Qué cláusulas son obligatorias en un bloque?','Las únicas cláusulas obligatorias son BEGIN y END','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'TEST','¿Quién requiere más código? A)Función B)Procedimiento C)Iguales','A)Función','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'TEST','¿Qué tipo de programa obliga a retornar un valor? A)PROCEDURE B)FUNCTION C)PACKAGE','B)FUNCTION','Pregunta tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'DESARROLLO','Indica donde se almacenan los programas PL/SQL y una de sus utilidades','Los programas creados con PL/SQL los podemos almacenar en nuestra base de datos como cualquier otro objeto quedando disponibles para los usuarios. El uso del lenguaje PL/SQL es imprescindible para construir disparadores de bases de datos (triggers)','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (5,'DESARROLLO','¿Qué es un Disparador o Trigger?','Los disparadores (o triggers) son bloques de código PL/SQL asociados a una tabla y que se ejecutan automáticamente como reacción a una operación DML específica (INSERT, UPDATE o DELETE) sobre dicha tabla','Pregunta de desarrollo');



/*RA3 - Programación de bases de datos usando PLSQL*/
/*CEV6 - Se han creado triggers para automatizar tareas*/
/*PREGUNTAS*/
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'CORTA','¿Cuándo se ejecuta un trigger?','Cuando se intenta modificar una tabla o vista asociada a él','Pregunta corta');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'CORTA','¿Cuál es el cometido principal de los triggers?','Conservar la integridad referencial entre tablas y registrar cambios o actuar cuando estos ocurren','Pregunta corta');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'TEST','¿Cuáles es una palabra reservada al momento en el que un trigger se activa? A)INSTEAD IN B)BELONG C)AFTER','C)AFTER','Pregunta de tipo test');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'TEST','¿Cuándo un trigger actúa a nivel de sentencia? A)Nunca B)Con STATEMENT C)Con FOR EACH ROW','B)Con STATEMENT','Pregunta tipo test');

INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'DESARROLLO','¿En qué se diferencian los procedimentos y los triggers?','En que no se pueden invocar directamente(se activan cuando se intenta modificar la tabla asociada a ellos), no reciben ni devuelven parámetros y sirven para mantener la integridad de los datos y no para obtener resultados de consultas','Pregunta de desarrollo');
INSERT INTO PREGUNTAS(COD_CEV,TIPO,ENUNCIADO,RESPUESTA,OBSERV) VALUES (6,'DESARROLLO','¿Cómo funciona un trigger?','El trigger se activa cuando la tabla asociada va a ser modificada, y lo hace en el momento(BEFORE o AFTER) y para el tipo de modificación realizada(INSERT, UPDATE o DELETE) y ejecuta el código que tiene en BEGIN','Pregunta de desarrollo');


/*--------------------------------------------------------------*/

commit;