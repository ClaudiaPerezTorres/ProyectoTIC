# Proyecto Asignación de oficinas

## Contexto del problema

Una de las mayores dificultades en Colombia para regresar a las instituciones
administrativas radica en la poca velocidad con la que ha ocurrido el proceso
de vacunación. A la fecha es muy difícil intermediar entre las diferentes
voluntades, deseos y posibilidades reales de regresar a clases presenciales. A
pesar de que aún no exista inmunidad de rebaño los entes administrativos
han optado por retornar a la presencialidad buscando salvaguardar otros
derechos y compromisos de su misión institucional como son el de otorgar
un excelente servicio a la comunidad.

En este orden de ideas, al interior de la Gobernación se ha propuesto un
retorno a la presencialidad asistido por tecnologías. La idea de esta iniciativa
es que se construyan sistemas que contribuyan con el mantenimiento de las
condiciones de bioseguridad. A los beneficiarios de Misiontic se les solicita
que construyan un sistema de información que permita validar las personas
que ingresan a la Gobernación.

En este sentido, hay que entender que es importante obtener información
como el nombre, apellidos, identificación, edad, estado COVID de las
personas. Adicionalmente, debe entenderse que existen varios roles de
personas que tienen autorizado el ingreso a la Gobernación, Gobernador y
asesores, secretarios de despacho, proveedores de servicios y personal de aseo. Para garantizar el cerco epidemiológico debe garantizarse que se maneja para cada rol información adicional de la siguiente manera:

| Rol | Datos adicionales |
|:-----:|-----|
| Gobernador y asesores | Oficinas visitadas |
| Secretario de despacho | Despacho |
| Proveedores de servicios | Servicio realizado, Unidad dondesarrolo el servicio |
| Personal de aseo | Turno en el que desarrollo el servicio |

## Requisitos generales

- El desarrollo debe indentificar el aforo de cada oficiona, la cantidad de oficinas disponibles en cada sede de la Gobernación por cada hora laboral.
- El sistema debe determinar si alguna de las personas autorizadas al ingreso tiene COVID, en ese caso el sistema debe registar los sitomas y la fecha en la fue diagnosticado.
- Si una persona resulta contagiada se le deb asignar un periodo de aislamiento obiglatorio a la persona e impedir su acceso a las instalaciones de la Universidad.
- También se deben analizar los datos registrados para identificar posibles focos epidmiológicos.
- Un foco se determina por la procedencia de mas de 3 contagios que pertenezcan a una misma oficina.

## Versiones de las herramientas

**DOTNET** = 3.1.413

**MSSQLLocalDB** = 15.0.2080.9

**.NET Framework64** = v4.0.30319

**Microsotf SQL Server 2019** = (RTM-GDR) (KB4583458) - 15.0.2080.9 (X64)   Nov  6 2020 16:50:01   Copyright (C) 2019 Microsoft Corporation  Express Edition (64-bit) on Windows 10 Home Single Language 10.0 <X64> (Build 19042: )
  
**SQL Server Management Studio** = 15.0.18386.0
  
**SQL Server Management Objects (SMO)** = 16.100.46437.65
  
**Microsoft Analysis Services Client Tools** = 15.0.19618.0
  
**Microsoft Data Access Components (MDAC)** = 10.0.19041.1
  
**Microsoft MSXML** = 3.0 6.0 
  
**Microsoft .NET Framework** = 4.0.30319.42000
  
**Operating System** = 10.0.19042
