# Facul_1_semestre

Projeto criado no primeiro semestre do curso de Análise e Desenvolvimento de Sistemas.
Software criado para cadastrar médicos, funcioinários, pacientes e armazenar relatórios de pacientes gerado por médicos.
Feito em linguagem C# utilizando o Visual Studio e banco de dados orientado a objetos db4o. Durante o desenvolvimento foi utilizado Git com repositório no bitbucket.

# Tela de Login
![Tela de Login](https://github.com/FelipeFadil/Facul_1_semestre/blob/master/print_telas/Tela_login.jpeg)
# Tela do funcionário
![Tela do funcionário](https://github.com/FelipeFadil/Facul_1_semestre/blob/master/print_telas/Tela_funcionario.jpeg)
# Tela de cadastro do paciente
![Tela de cadastro do paciente](https://github.com/FelipeFadil/Facul_1_semestre/blob/master/print_telas/Tela_cadastro_paciente.jpeg)
# Tela de cadastro do médico
![Tela de cadastro do médico](https://github.com/FelipeFadil/Facul_1_semestre/blob/master/print_telas/Tela_cadastro_medico.jpeg)
# Tela de cadastro do funcionário
![Tela de cadastro do funcionário](https://github.com/FelipeFadil/Facul_1_semestre/blob/master/print_telas/Tela_cadastro_funcionario.jpeg)
# Tela do médico
![Tela do médico](https://github.com/FelipeFadil/Facul_1_semestre/blob/master/print_telas/Tela_medico.jpeg)
# Tela de registro
![Tela de registro](https://github.com/FelipeFadil/Facul_1_semestre/blob/master/print_telas/Tela_registro.jpeg)

Na tela de login é necessário informar se é médico ou da secretaria para ser direcionado para a respectiva tela.<br>
Na tela do funcionário a pesquisa é filtrada pelo numero de dígitos (1 a 3 digitos - cód. funcionários / 4 a 10 digitos - CRM médicos / 11 digitos - CPF paciente)<br>
Na tela do médico a pesquisa é filtrada pelo CPF do paciente e pelo médico que está pesquisando, sendo assim, um médico não tem acesso aos registros gerados por outro médico.
