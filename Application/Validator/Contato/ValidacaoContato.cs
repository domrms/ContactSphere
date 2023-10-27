using Application.Interface.Contato;
using ApplicationDTO.RequestDTO.Contato;

namespace Application.Validator.Contato
{
    public class ValidacaoContato : ValidacaoBase, IValidacaoContato
    {
        private const string erroNomeInvalido = "O NOME É INVÁLIDO!";
        private const string erroEmailInvalido = "O EMAIL É INVÁLIDO!";
        private const string erroTelefoneInvalido = "O TELEFONE É INVÁLIDO!";
        private const string erroFkUsuarioInvalido = "O ID DO USUÁRIO É INVÁLIDO!";
        private const string erroIdUsuario = "O ID É INVÁLIDO!";

        public string ValidaDadosContato(RequestDadosContatoDto cadastrarContatoDto)
        {
            if (!ValidaNomeEmBranco(cadastrarContatoDto.Nome)) return erroNomeInvalido;
            if (!ValidaEmail(cadastrarContatoDto.Email)) return erroEmailInvalido;
            //if (!ValidaTelefone(cadastrarContatoDto.Telefone)) return erroTelefoneInvalido;
            if (!ValidaID(cadastrarContatoDto.FkIdUsuario)) return erroFkUsuarioInvalido;

            return string.Empty;
        }

        public string ValidaDadosUpdateContato(RequestUpdateContatoDTO cadastrarContatoDto)
        {
            if (!ValidaNomeEmBranco(cadastrarContatoDto.Nome)) return erroNomeInvalido;
            if (!ValidaEmail(cadastrarContatoDto.Email)) return erroEmailInvalido;
            //if (!ValidaTelefone(cadastrarContatoDto.Telefone)) return erroTelefoneInvalido;
            if (!ValidaID(cadastrarContatoDto.Id)) return erroFkUsuarioInvalido;

            return string.Empty;
        }

        public string ValidaDadosPorId(RequestContatoIdDTO requestContatoPorIdDTO)
        {
            if (!ValidaID(requestContatoPorIdDTO.Id)) return erroIdUsuario;

            return string.Empty;
        }
    }
}