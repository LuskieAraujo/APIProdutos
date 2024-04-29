using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProdutos.Produtos
{
    public class ProdutoController : Controller
    {
        private ProdutoService _service = new();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromBody] Produto produto)
        {
            try
            {
                return _service.New(produto) ? Ok() : BadRequest();
            }
            catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
        }
        [HttpGet]
        public ActionResult List()
        {
            try
            {
                return Ok(_service.Produtos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            try
            {
                return Ok(_service.Details(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromBody] Produto p)
        {
            try
            {
                return Ok(!_service.Update(id, p).Equals(null));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                return Ok(_service.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}