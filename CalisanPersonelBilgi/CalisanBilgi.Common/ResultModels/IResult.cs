namespace CalisanBilgi.Common.ResultModels
{
  public  interface IResult
    {
        public bool IsSucces { get; set; }
        public string Message { get; set; }
    }
}
