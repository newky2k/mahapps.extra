namespace MahApps.Extra.Automation.Peers
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Automation.Peers;
    using System.Windows.Automation.Provider;
    using System.Windows.Controls;
    using MahApps.Extra.Controls;

    /// <summary>
    /// Wraps an <see cref="T:System.Windows.Controls.AccordionItem" />.
    /// </summary>
    public class AccordionItemWrapperAutomationPeer : FrameworkElementAutomationPeer
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="AccordionItemWrapperAutomationPeer"/> class.
        /// </summary>
        /// <param name="item">The <see cref="T:System.Windows.Controls.AccordionItem" /> to wrap.</param>
        public AccordionItemWrapperAutomationPeer(AccordionItem item)
            : base(item)
        {
        }
    }
}
