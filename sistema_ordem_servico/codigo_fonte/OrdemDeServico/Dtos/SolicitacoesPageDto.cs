namespace OrdemDeServico.Dtos {
    public class SolicitacoesPageDto {
        public string Title { get; set; }
        public string DiaSelecionado { get; set; }
        public List<SolicitacaoDto> NomesEIds { get; set; }
    }

}
