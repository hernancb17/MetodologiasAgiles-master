using TechTalk.SpecFlow;
using FluentAssertions;
using TPAgilesGrupo1.Model;

namespace SpecFlowAhorcado.Specs.Steps
{
    [Binding]
    public sealed class AhorcadoStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private readonly Ahorcado ahorcado = new Ahorcado();
        private string character;
        private bool result;

        public AhorcadoStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("presiono jugar")]
        public void GivenPresionoJugar()
        {
           // Clickear UI
        }

        [Given("tecleo el caracter (.*)")]
        public void GivenIngresoCaracter(string character)
        {
            this.character = character;
        }

        [When("presiono la tecla ENTER")]
        public void WhenPresionoEnter()
        {
            this.result = ahorcado.ValidarIngresoLetra(character);
        }

        [Then("el sistema deberia decirme: (.*)")]
        public void ThenTheResultShouldBe(string message)
        {
            if (!this.result)
            {
                message.Should().Be("Ingrese un caracter valido");
            }
            else
            {
                message.Should().Be("");
            }
            
        }
    }
}
