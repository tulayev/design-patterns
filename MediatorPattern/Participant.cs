namespace MediatorPattern
{
    internal class Participant
    {
        public int Value { get; set; }
        
        private readonly Mediator _mediator;

        public Participant(Mediator mediator)
        {
            _mediator = mediator;
            _mediator.Alerts += OnAlert!;
        }

        public void Say(int n)
        {
            _mediator.Broadcast(this, n);
        }

        private void OnAlert(object sender, int n)
        {
            if (sender != this)
            {
                Value += n;
            }
        }
    }
}
